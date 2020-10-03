using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace Intent.Modules.Common.Html.Editor
{
    public static class HtmlNodeExtensions
    {
        public static string GetRelativeXPath(this HtmlNode node)
        {
            var identifier = node.GetAttributeValue("intent-id", null);
            if (identifier != null)
            {
                return $"//*[@intent-id='{identifier}']";
            }

            if (node.GetAttributeValue("id", null) != null)
            {
                return $"//*[@id='{node.GetAttributeValue("id", null)}']";
            }

            var parentPath = node.ParentNode?.XPath;
            var xPath = parentPath != null && node.XPath.StartsWith(parentPath)
                ? node.XPath.Substring(parentPath.Length + 1)
                : node.XPath;

            return xPath;
        }

        public static bool IsIgnored(this HtmlNode node)
        {
            return node.GetAttributeValue("intent-ignore", null) != null;
        }

        public static bool IsMerged(this HtmlNode node)
        {
            return node.GetAttributeValue("intent-merge", null) != null;
        }

        public static bool IsFullyManaged(this HtmlNode node)
        {
            return node.GetAttributeValue("intent-manage", null)?.Trim() == string.Empty;
        }

        public static bool HasIntentId(this HtmlNode node)
        {
            return node.GetAttributeValue("intent-id", null) != null;
        }

        public static bool CanAdd(this HtmlNode node)
        {
            return node.IsFullyManaged() || node.IsMerged() 
                || node.GetAttributeValue("intent-can-add", null) != null
                || (node.GetAttributeValue("intent-manage", null)?.Contains("add") ?? false);
        }

        public static bool CanOverwrite(this HtmlNode node)
        {
            return node.IsFullyManaged() || node.IsMerged() 
                || node.GetAttributeValue("intent-can-overwrite", null) != null
                || (node.GetAttributeValue("intent-manage", null)?.Contains("overwrite") ?? false);
        }

        public static bool CanRemove(this HtmlNode node)
        {
            return node.IsFullyManaged() 
                || node.GetAttributeValue("intent-can-remove", null) != null
                || (node.GetAttributeValue("intent-manage", null)?.Contains("remove") ?? false);
        }

        public static bool HasIntentAttribute(this HtmlNode node)
        {
            return node.GetAttributeValue("intent-ignore", null) != null
                   || node.GetAttributeValue("intent-merge", null) != null
                   || node.GetAttributeValue("intent-manage", null) != null
                   || node.GetAttributeValue("intent-can-add", null) != null
                   || node.GetAttributeValue("intent-can-overwrite", null) != null
                   || node.GetAttributeValue("intent-can-remove", null) != null;
        }

        public static IList<HtmlNode> ChildElements(this HtmlNode node)
        {
            return node.ChildNodes.Where(x => x.NodeType == HtmlNodeType.Element).ToList();
        }

        public static void AppendChildWithWhitespace(this HtmlNode node, HtmlNode newNode)
        {
            node.Append(GetOuterHtmlWithWhitespace(newNode));
        }

        public static void InsertChildWithWhitespace(this HtmlNode node, int index, HtmlNode newNode)
        {
            node.Insert(index, GetOuterHtmlWithWhitespace(newNode));
        }

        private static string GetOuterHtmlWithWhitespace(this HtmlNode node)
        {
            var leadingWs = Regex.Match(node.ParentNode.InnerHtml, "^\\s*").Value;
            var trailingWs = Regex.Match(node.ParentNode.InnerHtml, "\\s*$").Value;
            return $"{leadingWs}{node.OuterHtml}{trailingWs}";
        }

        public static void Append(this HtmlNode node, string html)
        {
            var htmlDoc = new HtmlDocument()
            {
                OptionOutputOriginalCase = true,
                OptionWriteEmptyNodes = true
            };
            htmlDoc.LoadHtml(string.IsNullOrEmpty(node.InnerHtml)
                ? $@"<wrapper>{html}</wrapper>"
                : $@"<wrapper>  {html.TrimStart()}</wrapper>");

            //var nodeIndentation = Regex.Match(node.ParentNode.InnerHtml, "^\\s*").Value;
            //var htmlLines = html.Split(new[] {'\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);
            //var leadingWs = Regex.Match(node.ParentNode.InnerHtml, "^\\s*").Value;
            //var normalizedLines = htmlLines.Select(x => x.Substring(htmlLines[0]))

            node.AppendChildren(htmlDoc.DocumentNode.SelectSingleNode("//wrapper").ChildNodes);
        }

        public static void Insert(this HtmlNode node, int index, string html)
        {
            if (index >= node.ChildElements().Count)
            {
                node.Append(html);
                return;
            }

            var children = node.DuplicateNode().ChildElements();
            node.RemoveAllChildren();
            var i = 0;
            while (i < children.Count)
            {
                if (i == index)
                {
                    node.Append(html);
                }
                node.AppendChildWithWhitespace(children[i]);
                i++;
            }
        }

        public static void ReplaceWith(this HtmlNode node, HtmlNode replaceWith)
        {
            var htmlDoc = new HtmlDocument()
            {
                OptionOutputOriginalCase = true,
                OptionWriteEmptyNodes = true
            };
            htmlDoc.LoadHtml($"<wrapper>{replaceWith.OuterHtml}</wrapper>");
            node.ParentNode.ReplaceChild(htmlDoc.DocumentNode.SelectSingleNode("//wrapper").ChildElements().Single(), node);
        }

        public static void RemoveWithWhitespace(this HtmlNode parent, params HtmlNode[] toRemove)
        {
            var htmlDoc = new HtmlDocument()
            {
                OptionOutputOriginalCase = true,
                OptionWriteEmptyNodes = true
            };
            htmlDoc.LoadHtml("<wrapper></wrapper>");
            foreach (var toKeep in parent.ChildElements().Where(x => !toRemove.Contains(x)))
            {
                htmlDoc.DocumentNode.SelectSingleNode("//wrapper").AppendChildWithWhitespace(toKeep);
            }
            parent.RemoveAllChildren();
            parent.AppendChildren(htmlDoc.DocumentNode.SelectSingleNode("//wrapper").ChildNodes);
        }

        public static HtmlNode DuplicateNode(this HtmlNode node)
        {
            var htmlDoc = new HtmlDocument()
            {
                OptionOutputOriginalCase = true,
                OptionWriteEmptyNodes = true
            };
            htmlDoc.LoadHtml($"<wrapper>{node.OuterHtml}</wrapper>");
            return htmlDoc.DocumentNode.SelectSingleNode("//wrapper").ChildElements().Single();
        }
    }
}