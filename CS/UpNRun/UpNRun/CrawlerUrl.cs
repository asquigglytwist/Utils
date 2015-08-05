using System;

namespace UpNRun
{
    internal class CrawlerUrl : IEquatable<CrawlerUrl>
    {
        internal CrawlerUrl(string url, UriKind kind = UriKind.RelativeOrAbsolute)
        {
            bool bValid;
            Uri temp = ValidationHelper.IsValidUri(out bValid, url, kind);
            if (bValid)
                ThisUri = temp;
            else
                throw new ArgumentException("Cannot create CrawlerUrl; Either invalid or is not Absolute.", "url");
        }

        internal CrawlerUrl(Uri uri)
        {
            ThisUri = uri;
        }

        internal Uri ThisUri { get; private set; }
        internal bool WasCrawled { get; set; }

        internal string StringRepresentation
        {
            get
            {
                return ("[Url]:  " + ThisUri.AbsolutePath + "\t[Crawled]:  " + WasCrawled);
            }
        }

        bool Equals(CrawlerUrl other)
        {
            if (other == null)
                return false;
            return this.ThisUri.AbsolutePath.Equals(other.ThisUri.AbsolutePath, StringComparison.CurrentCultureIgnoreCase);
        }

        public override int GetHashCode()
        {
            return ThisUri.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (null == obj)
                return false;
            CrawlerUrl other = obj as CrawlerUrl;
            if (null == other)
                return false;
            return Equals(other);
        }

        public static bool operator ==(CrawlerUrl url1, CrawlerUrl url2)
        {
            if (object.ReferenceEquals(url1, null))
            {
                return object.ReferenceEquals(url2, null);
            }
            return url1.Equals(url2);
        }

        public static bool operator !=(CrawlerUrl url1, CrawlerUrl url2)
        {
            return !(Equals(url1, url2));
        }

        public override string ToString()
        {
            return StringRepresentation;
        }

        bool IEquatable<CrawlerUrl>.Equals(CrawlerUrl other)
        {
            return this.Equals(other);
        }
    }
}
