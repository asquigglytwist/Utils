using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WebSnapper
{
    [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
    [System.Runtime.InteropServices.ComVisible(true)]
    class WebSnapper
    {
        private const string AppName = "WebSnapper",
            AppConfigFileName = AppName + ".config";
        private const string WSSXWebSnapperTask = "WebSnapperTask",
            WSSXLookForKeyWord = "LookForKeyWord",
            WSSXMailRecepients = "MailRecepient",
            WSSXStyleSheets = "StyleSheet";
        private const string LookForKeyWordDef = "[" + AppName + "]";

        private string ConfigFilePath;
        private List<WebSnapperTask> WebSnapperTasks;
        private List<string> StyleSheetsToLink;
        private StringBuilder EMailBody;

        internal WebSnapper()
        {
            EMailBody = new StringBuilder();
            WebSnapperTasks = new List<WebSnapperTask>();
            StyleSheetsToLink = new List<string>();
            var currentDirPath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase), AppConfigFileName);
            var myDocsSubPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), AppName, AppConfigFileName);
            var myDocsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), AppConfigFileName);
            ConfigFilePath = string.Empty;
            if(File.Exists(currentDirPath))
            {
                ConfigFilePath = currentDirPath;
            }
            else if (File.Exists(myDocsSubPath))
            {
                ConfigFilePath = myDocsSubPath;
            }
            else if (File.Exists(myDocsPath))
            {
                ConfigFilePath = myDocsPath;
            }
            LoadConfig();
        }

        private string GetNodeValue(XElement entry)
        {
            var value = string.Empty;
            if (entry != null)
            {
                value = entry.Value.Trim();
            }
            return value;
        }

        private string GetAttributeValue(XElement entry, string attribute)
        {
            var value = string.Empty;
            var attrib = entry.Attribute(attribute);
            if(attrib!=null)
            {
                value = attrib.Value.Trim();
            }
            return value;
        }

        private List<string> GetChildrenAsList(XDocument xDoc, string tagName)
        {
            var childrenValues = (from child in xDoc.Descendants(tagName) select child.Value);
            return childrenValues.ToList();
        }

        protected bool LoadConfig()
        {
            EMailBody?.Clear();
            WebSnapperTasks?.Clear();
            StyleSheetsToLink?.Clear();
            if (!string.IsNullOrWhiteSpace(ConfigFilePath))
            {
                //[BIB]:  https://stackoverflow.com/a/8181799
                XDocument xDoc = XDocument.Load(ConfigFilePath);
                var urls = xDoc.Descendants(WSSXWebSnapperTask);
                foreach (var entry in urls)
                {
                    var temp1 = GetAttributeValue(entry, "pathsToExtract");
                    var attrPathsToExtract = GetAttributeValue(entry, "pathsToExtract");
                    var attrSnapTitle = GetAttributeValue(entry, "snapTitle");
                    var temp = GetAttributeValue(entry, "updateAndRetry");
                    var attrUpdateAndRetry = false;
                    if (!string.IsNullOrWhiteSpace(temp))
                    {
                        attrUpdateAndRetry = bool.Parse(temp);
                    }
                    var val = GetNodeValue(entry);
                    if (!string.IsNullOrWhiteSpace(val))
                    {
                        var webSnapperTask = new WebSnapperTask(val, attrSnapTitle, attrPathsToExtract, attrUpdateAndRetry);
                        WebSnapperTasks.Add(webSnapperTask);
                        if (attrUpdateAndRetry)
                        {
                            var updateSteps = entry.Descendants("Step");
                            foreach (var step in updateSteps)
                            {
                                string act = GetAttributeValue(step, "action"), target = GetAttributeValue(step, "target"),
                                    value = string.Empty;
                                var action = InPageAction.None;
                                if(act.Equals("SetValue", StringComparison.CurrentCultureIgnoreCase))
                                {
                                    action = InPageAction.SetValue;
                                    value = GetAttributeValue(step, "value");
                                }
                                else if (act.Equals("Click", StringComparison.CurrentCultureIgnoreCase))
                                {
                                    action = InPageAction.Click;
                                }
                                var subTask = new SubTask(action, target, value);
                                webSnapperTask.AddSubTask(subTask);
                            }
                        }
                    }
                }
                var keyWordNode = xDoc.Descendants(WSSXLookForKeyWord).FirstOrDefault();
                LookForKeyWord = GetNodeValue(keyWordNode);
                MailRecepients = GetChildrenAsList(xDoc, WSSXMailRecepients);
                StyleSheetsToLink = GetChildrenAsList(xDoc, WSSXStyleSheets);
                return true;
            }
            MessageBox.Show("Oops!!  No config file found.\nNo cookie for you.");
            return false;
        }

        internal string GetAllURLContents()
        {
            EMailBody.Clear();
            foreach (var styleSheet in StyleSheetsToLink)
            {
                EMailBody.AppendFormat("<link href=\"{0}\" rel=\"stylesheet\" type=\"text/css\">", styleSheet);
            }
            var iIndex = 0;
            foreach (var task in WebSnapperTasks)
            {
                try
                {
                    var responseContent = "URI not reachable...";
                    var linkTitle = task.SnapTitle;
                    if (BrowserEx.IsURIReachable(task.UrlToVisit))
                    {
                        var browser = new BrowserEx();
                        browser.PerformWebSnapperTask(task);
                        while (!browser.ContentRetrieved)
                        {
                            //[BIB]:  https://stackoverflow.com/questions/5181777/use-of-application-doevents
                            Application.DoEvents();
                            System.Threading.Thread.Sleep(1000);
                        }
                        responseContent = browser.PageContent;
                        if (string.IsNullOrWhiteSpace(linkTitle))
                        {
                            linkTitle = browser.DocumentTitle;
                        }
                    }
                    EMailBody.AppendFormat("<u>URI [{0}]: &nbsp;<a href=\"{1}\">{2}</a></u><br />{3}<br /><hr /><br /><br />",
                        iIndex, task.UrlToVisit, linkTitle, responseContent);
                    iIndex++;
                }
                catch (Exception e)
                {
                    MessageBox.Show(string.Format("Unable to get contents of URL:{0}\"{1}\"{0}{0}{2}",
                        Environment.NewLine, task.UrlToVisit, e.Message));
                }
            }
            return EMailBody.ToString();
        }

        internal string LookForKeyWord
        {
            get;
            private set;
        }

        internal List<string> MailRecepients
        {
            get;
            private set;
        }
    }

    struct WebSnapperTask
    {
        public string UrlToVisit
        { get; private set; }
        public string SnapTitle
        { get; private set; }
        public string PathsToExtract
        { get; private set; }
        public bool UpdateAndRetry
        { get; private set; }
        public List<SubTask> Steps
        { get; private set; }
        public List<SubTask>.Enumerator SubTaskIterator
        {
            get
            {
                return Steps.GetEnumerator();
            }
        }

    internal WebSnapperTask(string urlToVisit, string snapTitle, string pathsToExtract, bool updateAndRetry)
        {
            UrlToVisit = urlToVisit;
            SnapTitle = snapTitle;
            PathsToExtract = pathsToExtract;
            UpdateAndRetry = updateAndRetry;
            Steps = new List<SubTask>();
        }

        internal void AddSubTask(SubTask subTask)
        {
            Steps.Add(subTask);
        }
    }

    enum InPageAction
    {
        None,
        SetValue,
        Click
    }

    struct SubTask
    {
        public InPageAction Action
        { get; private set; }
        public string Target
        { get; private set; }
        public string Value
        { get; private set; }

        internal SubTask(InPageAction action, string target, string value)
        {
            Action = action;
            Target = target;
            Value = value;
        }
    }
}
