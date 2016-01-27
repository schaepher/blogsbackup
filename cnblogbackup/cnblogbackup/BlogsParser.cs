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

        public static Dictionary<string, string> GetDictionary(string baseUrl)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            string pageTail = "?page=1";
            string url = baseUrl + pageTail;

            while (true)
            {
                string html = GetHtml(url);

                Dictionary<string, string> temp = new Dictionary<string, string>();
                temp = GetTitleAndUrl(html);
                dic = dic.Concat(temp).ToDictionary(k => k.Key, v => v.Value);

                string nextPageTail = GetNextPage(html);

                if (nextPageTail != "")
                {
                    url = baseUrl + nextPageTail;
                }
                else
                {
                    break;
                }
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

        private static Dictionary<string, string> GetTitleAndUrl(string htmlContent)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            string pattern = "HomePageDays_DaysList_ctl\\d+_DayList_TitleUrl_0\" class=\"postTitle2\" href=\"(.+?)\">(.+?)</a>";
            Regex rgx = new Regex(pattern, RegexOptions.Singleline);
            MatchCollection matchesResults = rgx.Matches(htmlContent);

            foreach (Match match in matchesResults)
            {
                GroupCollection groups = match.Groups;
                dic.Add(groups[1].Value, groups[2].Value);
            }

            return dic;
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

    }

}
