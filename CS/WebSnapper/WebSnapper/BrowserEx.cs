using System;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace WebSnapper
{
    internal class BrowserEx : WebBrowser
    {
        public string TargetURI
        { get; private set; }
        public string CSSPathFilter
        { get; private set; }
        public string PageContent
        { get; private set; }
        public bool HasDocumentCompleted
        { get; private set; }
        public bool ContentRetrieved
        { get; private set; }

        bool performingWebSnapperTask;
        private const int MaxAttempts = 5;

        internal BrowserEx(bool visibility = false)
        {
            Visible = visibility;
            ScriptErrorsSuppressed = true;
            IsWebBrowserContextMenuEnabled = false;
            TabStop = false;
            WebBrowserShortcutsEnabled = false;
            DocumentCompleted += WebBrowser_DocumentCompleted;
            PageContent = string.Empty;
            HasDocumentCompleted = ContentRetrieved = performingWebSnapperTask = false;
        }

        private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            var browser = sender as BrowserEx;
            if (!browser.IsBusy)
            {
                Application.DoEvents();
                Thread.Sleep(1000);
                var doc = browser.Document;
                var content = new System.Text.StringBuilder();
                if (!string.IsNullOrWhiteSpace(browser.CSSPathFilter))
                {
                    if (CSSPathFilter.Equals("body", StringComparison.CurrentCultureIgnoreCase))
                    {
                        browser.PageContent = doc.Body.InnerHtml;
                    }
                    else
                    {
                        foreach (var cssPath in browser.CSSPathFilter.Split(new[] { ',' }))
                        {
                            try
                            {
                                var tempContent = doc.Body.QuerySelectorAll(cssPath);
                                if (!string.IsNullOrWhiteSpace(tempContent))
                                {
                                    content.Append(tempContent);
                                    content.Append("<br />");
                                }
                            }
                            catch (Exception)
                            {
                            }
#if DEBUG
                            Thread.Sleep(1000);
#endif
                            browser.PageContent = ((content.Length < 0) ? doc.Body.InnerHtml : content.ToString());
                        }
                    }
                }
                else
                {
                    browser.PageContent= doc.GetElementsByTagName("html")[0].InnerHtml;
                }
                browser.HasDocumentCompleted = true;
            }
        }

        internal static bool IsURIReachable(string uri)
        {
            HttpWebRequest webRequest = WebRequest.Create(uri) as HttpWebRequest;
            //[BIB]:  https://stackoverflow.com/questions/5378429/check-if-a-url-is-reachable-help-in-optimizing-a-class
            webRequest.Timeout = 15000;
            webRequest.Method = "HEAD";
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse())
                {
                    return response.StatusCode == HttpStatusCode.OK;
                }
            }
            catch (WebException)
            {
            }
            return false;
        }

        protected void NavigateToTarget()
        {
            while (IsBusy && performingWebSnapperTask)
            {
                Application.DoEvents();
                Thread.Sleep(1000);
            }
            HasDocumentCompleted = false;
            Navigate(TargetURI);
            Application.DoEvents();
            Thread.Sleep(1000);
        }

        internal void PerformWebSnapperTask(WebSnapperTask task)
        {
            TargetURI = task.UrlToVisit;
            CSSPathFilter = task.PathsToExtract;
            performingWebSnapperTask = true;
            int attempts = 1;
            NavigateToTarget();
            while (performingWebSnapperTask && attempts < MaxAttempts)
            {
                bool aSubTaskWasExecuted = false;
                while (!HasDocumentCompleted)
                {
                    //[BIB]:  https://stackoverflow.com/questions/5181777/use-of-application-doevents
                    Application.DoEvents();
                    Thread.Sleep(1000);
                }
                foreach (var subTask in task.Steps)
                {
                    // [BIB]:  https://stackoverflow.com/questions/19778108/switch-enum-auto-fill
                    switch (subTask.Action)
                    {
                        case InPageAction.None:
                            break;
                        case InPageAction.SetValue:
                            SetElementValue(subTask.Target, subTask.Value);
                            break;
                        case InPageAction.Click:
                            ClickElement(subTask.Target);
                            break;
                        default:
                            break;
                    }
                    aSubTaskWasExecuted = true;
#if DEBUG
                    Thread.Sleep(1000);
#endif
                }
                task.Steps.Clear();
                if (!aSubTaskWasExecuted)
                {
                    performingWebSnapperTask = false;
                    ContentRetrieved = true;
                }
                attempts++;
            }
        }

        internal void SetElementValue(string idOfElement, string valueToSet)
        {
            var elt = Document.GetElementById(idOfElement);
            if (elt != null)
            {
                elt.SetAttribute("value", valueToSet);
                Application.DoEvents();
                Thread.Sleep(1000);
            }
        }

        internal void ClickElement(string idOfElement)
        {
            var elt = Document.GetElementById(idOfElement);
            if (elt != null)
            {
                HasDocumentCompleted = false;
                // [BIB]:  https://stackoverflow.com/questions/13456254/how-to-click-a-button-in-webbrowser-document-without-id
                //elt.RaiseEvent("onclick");
                elt.InvokeMember("click");
                Application.DoEvents();
                Thread.Sleep(1000);
            }
        }
    }
}
