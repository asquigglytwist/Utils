using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using HAP = HtmlAgilityPack;

namespace UpNRun
{
    internal static class ValidationHelper
    {
        internal static bool IsValidAnchor(HAP.HtmlNode ndAnchor)
        {
            if(ndAnchor.Attributes.Contains("href"))
            {
                bool bValid;
                IsValidUri(out bValid, ndAnchor.Attributes["href"].Value);
                return bValid;
            }
            return false;
        }

        internal static Uri IsValidUri(out bool isValid, string url, UriKind kind = UriKind.RelativeOrAbsolute)
        {
            isValid = false;
            if(string.IsNullOrEmpty(url))
                return null;
            Uri temp;
            isValid = Uri.TryCreate(url, kind, out temp);
            return temp;
        }
    }
}
