using System;
using System.Linq;
using System.Windows.Forms;

namespace WebSnapper
{
    internal static class DOMHelper
    {
        static string[] KnownTags = {
            "a", "abbr", "acronym", "address", "applet", "area", "article", "aside", "audio",
            "b", "base", "basefont", "bdi", "bdo", "big", "blockquote", "body", "br", "button",
            "canvas", "caption", "center", "cite", "code", "col", "colgroup",
            "datalist", "dd", "del", "details", "dfn", "dialog", "dir", "div", "dl", "dt",
            "em", "embed",
            "fieldset", "figcaption", "figure", "font", "footer", "form", "frame", "frameset",
            "h1", "h2", "h3", "h4", "h5", "h6", "h7", "head", "header", "hr", "html",
            "i", "iframe", "img", "input", "ins",
            "kbd",
            "label", "legend", "li", "link",
            "main", "map", "mark", "menu", "menuitem", "meta", "meter",
            "nav", "noframes", "noscript",
            "object", "ol", "optgroup", "option", "output",
            "p", "param", "picture", "pre", "progress",
            "q",
            "rp", "rt", "ruby",
            "s", "samp", "script", "section", "select", "small", "source", "span", "strike",
                    "strong", "style", "sub", "summary", "sup",
            "table", "tbody", "td", "template", "textarea", "tfoot", "th", "thead", "time",
                    "title", "tr", "track", "tt",
            "u", "ul",
            "var", "video",
            "wbr"
        };

        internal static string QuerySelectorAll(this HtmlElement elem, string cssPath)
        {
            if (string.IsNullOrWhiteSpace(cssPath))
            {
                return elem.OuterHtml;
            }
            cssPath = cssPath.Trim();
            var tokens = cssPath.Split(new char[] { ' ', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            foreach (var token in tokens)
            {
                //tokens.Remove(token);
                if (token.Contains('#'))
                {
                    var subTokens = token.Split(new char[] { '#' }, StringSplitOptions.RemoveEmptyEntries);
                    elem = elem.Document.GetElementById(subTokens[subTokens.Length - 1]);
                }
                else if (token.Contains('.'))
                {
                    var subTokens = token.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                    HtmlElementCollection targetNodes = elem.Children;
                    if (subTokens.Length == 2)
                    {
                        targetNodes = elem.GetElementsByTagName(subTokens[0]);
                    }
                    foreach (HtmlElement target in targetNodes)
                    {
                        //[BIB]:  https://stackoverflow.com/questions/1157258/find-specific-data-in-html-with-htmlelementcollection-and-webbrowser
                        var classInfo = target.GetAttribute("className");
                        if (!string.IsNullOrEmpty(classInfo))
                        {
                            var classes = classInfo.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            if (classes.Contains(subTokens[1]))
                            {
                                elem = target;
                                break;
                            }
                        }
                    }
                }
                else if (KnownTags.Contains(token))
                {
                    var targetNodes = elem.GetElementsByTagName(token);
                    if(targetNodes.Count > 0)
                    {
                        elem = targetNodes[0];
                    }
                }
            }
            return elem.OuterHtml;
        }
    }
}
