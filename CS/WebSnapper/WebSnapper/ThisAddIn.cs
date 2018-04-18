using System;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace WebSnapper
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, EventArgs e)
        {
            Application.Reminder += Application_Reminder;
        }

        private void Application_Reminder(dynamic Item)
        {
            var webSnapper = new WebSnapper();
            var reminder = Item.Subject;
            if (reminder.Contains(webSnapper.LookForKeyWord))
            {
                var content = webSnapper.GetAllURLContents();
                if (!string.IsNullOrWhiteSpace(content))
                {
                    Outlook.MailItem mail = Application.CreateItem(Outlook.OlItemType.olMailItem) as Outlook.MailItem;
                    mail.BodyFormat = Outlook.OlBodyFormat.olFormatHTML;
                    mail.HTMLBody = content;
                    mail.Subject = string.Format("[{0}] - {1}", webSnapper.LookForKeyWord, DateTime.Now.ToString("yyyy/MM/dd  hh:mm:tt"));
                    int recepientCount = 0;
                    foreach (string recepient in webSnapper.MailRecepients)
                    {
                        recepientCount++;
                        mail.Recipients.Add(recepient);
                    }
                    if (recepientCount < 1)
                    {
                        var fallBackRecepient = Application.Session.CurrentUser.AddressEntry.Address;
                        if (fallBackRecepient == null)
                        {
                            fallBackRecepient = Application.Session.CurrentUser.AddressEntry.GetExchangeUser().PrimarySmtpAddress;
                            if (fallBackRecepient == null)
                            {
                                fallBackRecepient = "<Fall_Back_Email_Id_Here>";
                            }
                        }
                        mail.Recipients.Add(fallBackRecepient);
                    }
                    mail.Recipients.ResolveAll();
                    mail.Send();
                    Item.Dismiss();
                }
            }
        }

        private void ThisAddIn_Shutdown(object sender, EventArgs e)
        {
            // Note: Outlook no longer raises this event. If you have code that 
            //    must run when Outlook shuts down, see http://go.microsoft.com/fwlink/?LinkId=506785
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
