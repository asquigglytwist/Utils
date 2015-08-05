using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using HAP = HtmlAgilityPack;
using System;

namespace UpNRun
{
    public class Crawler
    {
        static List<CrawlerUrl> UrlsEncountered;

        private string m_sUrlThis;
        private Uri m_uriThis;
        private HAP.HtmlWeb m_hwWeb;
        private HAP.HtmlDocument m_hdDoc;
        
        public Crawler(string sUrl)
        {
            m_sUrlThis = sUrl;
            m_hwWeb = new HAP.HtmlWeb()
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.GetEncoding("iso-8859-2"),
                UserAgent = Global.UserAgent
            };
            // Has to be made available only on-demand by user and not by default since this will leave the machine vulnerable for MITM attack.
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
            UrlsEncountered = new List<CrawlerUrl>();
            // Only the first URL (i.e., starting point) has to be an absolute URL.
            UrlsEncountered.Add(new CrawlerUrl(m_sUrlThis, System.UriKind.Absolute));
            m_uriThis = new Uri(m_sUrlThis);
            m_hdDoc = m_hwWeb.Load(m_sUrlThis);
        }

        public void BeginCrawl()
        {
            var ndAllLinks = m_hdDoc.DocumentNode.Descendants("a").Where(x => ValidationHelper.IsValidAnchor(x));
            foreach (var ndLink in ndAllLinks)
            {
                Uri temp = new Uri(m_uriThis, ndLink.Attributes["href"].Value);
                var crawlerUrl = new CrawlerUrl(temp.AbsoluteUri);
                if (!UrlsEncountered.Contains(crawlerUrl))
                    UrlsEncountered.Add(crawlerUrl);
            }
        }
    }
}
