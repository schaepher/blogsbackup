using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;

namespace cnblogbackup
{
    public class BlogsParser
    {
        private static WebClient client = null;

        public static Dictionary<string, string> UrlTitleDic(string baseUrl)
        {
            Dictionary<string, string> dicAll = new Dictionary<string, string>();

            string pageTail = "?page=1";
            string url = baseUrl + pageTail;

            while (true)
            {
                string html = GetHtml(url);

                Dictionary<string, string> dicTemp = new Dictionary<string, string>();
                string pattern = "HomePageDays_DaysList_ctl\\d+_DayList_TitleUrl_0\" class=\"postTitle2\" href=\"(.+?)\">(.+?)</a>";
                dicTemp = GetDictionary(html, pattern);
                dicAll = MergeDictionary(dicAll, dicTemp);
                string nextPageTail = GetNextPage(html);
                if (nextPageTail != "")
                    url = baseUrl + nextPageTail;
                else
                    break;
            }
            return dicAll;
        }

        public enum Options { FromBlogContent, FromBlogComment };

        public static Dictionary<string, string> NumberHomepageDic(string url, Options option)
        {
            Dictionary<string, string> dicAll = new Dictionary<string, string>();
            string pattern;
            string html;
            switch (option)
            {
                case Options.FromBlogContent:
                    html = GetHtml(url);
                    pattern = "(\\d+)\\s*<a href=\"(.+?)\"";
                    dicAll = GetDictionary(html, pattern);
                    break;
                case Options.FromBlogComment:
                    pattern = "http://www.cnblogs.com/(.+?)/p/(\\d+).html";
                    Regex rgx = new Regex(pattern);
                    GroupCollection groups = rgx.Match(url, 0).Groups;
                    string postId = groups[2].Value;
                    string blogApp = groups[1].Value;
                    string baseUrl = "http://www.cnblogs.com/mvc/blog/GetComments.aspx?postId=" + postId + "&blogApp=" + blogApp + "&pageIndex=";
                    var tempEntity = new { commentCount = 0, commentsHtml = string.Empty };
                    int pageIndex = 1;
                    Dictionary<string, string> dicTemp;
                    do
                    {
                        url = baseUrl + pageIndex;
                        html = GetHtml(url);
                        tempEntity = JsonHelper.DeserializeAnonymousType(html, tempEntity);
                        html = tempEntity.commentsHtml;
                        pattern = "comment_body\">(\\d{3,}).+?(http://www.cnblogs.com/.+?)[/|\"].+?</div>";
                        dicTemp = GetDictionary(html, pattern);
                        dicAll = MergeDictionary(dicAll, dicTemp);
                        pageIndex++;
                    } while (dicTemp.Count != 0);
                    break;
                default:
                    break;
            }

            Dictionary<string, string> dicSorted = dicAll.OrderBy(o => o.Key).ToDictionary(o => o.Key, p => p.Value);

            return dicSorted;
        }

        private static Dictionary<string, string> GetDictionary(string htmlContent, string pattern)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            Regex rgx = new Regex(pattern, RegexOptions.Singleline);
            MatchCollection matchesResults = rgx.Matches(htmlContent);

            foreach (Match match in matchesResults)
            {
                GroupCollection groups = match.Groups;
                if (!dic.ContainsKey(groups[1].Value))
                    dic.Add(groups[1].Value, groups[2].Value);
            }

            return dic;
        }

        private static string GetHtml(string url)
        {
            if (client == null)
            {
                client = new WebClient();
                client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            }

            Stream data = client.OpenRead(url);
            StreamReader reader = new StreamReader(data);
            string content = reader.ReadToEnd();
            data.Close();
            reader.Close();
            return content;
        }

        private static string GetNextPage(string html)
        {
            string pattern = "default.html(\\?page=\\d+)\">下一页</a>";
            Regex rgx = new Regex(pattern, RegexOptions.Singleline);
            Match match = rgx.Match(html);
            GroupCollection group = match.Groups;
            string nextPageTail = group[1].Value;
            return nextPageTail;
        }

        public class JsonHelper
        {

            public static T DeserializeAnonymousType<T>(string json, T anonymousTypeObject)
            {
                T t = JsonConvert.DeserializeAnonymousType(json, anonymousTypeObject);
                return t;
            }

            public static string SerializeObject(object o)
            {
                string json = JsonConvert.SerializeObject(o);
                return json;
            }
        }

        public static Dictionary<string, string> MergeDictionary(Dictionary<string, string> first, Dictionary<string, string> second)
        {
            if (second == null) return first;

            foreach (KeyValuePair<string, string> kvp in second)
            {
                if (first.ContainsKey(kvp.Key))
                    first.Remove(kvp.Key);
                first.Add(kvp.Key, kvp.Value);
            }
            return first;
        }

    }

}
