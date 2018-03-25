using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Consuum.Core.Models;

namespace Consuum.Core.Services
{
    public class UrlValidationService
    {

        public List<string> ParseForUrls(string input)
        {
            return UrlRegex(input);
        }

        public List<string> ParseForUrls(string input, out int numberFound)
        {
            var result = UrlRegex(input);
            numberFound = result.Count;

            return result;
        }

        private List<string> UrlRegex(string input)
        {
            #region attempts for reference
            //var text = Regex.Replace(input,
            //    @"((http|ftp|https):\/\/[\w\-_]+(\.[\w\-_]+)+([\w\-\.,@?^=%&amp;:/~\+#]*[\w\-\@?^=%&amp;/~\+#])?)",
            //    "<a target='_blank' href='$1'>$1</a>");

            /* Loop through the regex output
             * and for each url increment the cound
             * then return that result or else return 0
             */
            //return 0;

            //This one doesn't catch https
            //Regex regx = new Regex("http://([\\w+?\\.\\w+])+([a-zA-Z0-9\\~\\!\\@\\#\\$\\%\\^\\&amp;\\*\\(\\)_\\-\\=\\+\\\\\\/\\?\\.\\:\\;\\'\\,]*)?", RegexOptions.IgnoreCase);

            //This one finds http and https well!
            //Regex regx = new Regex(@"((http|ftp|https):\/\/[\w\-_]+(\.[\w\-_]+)+([\w\-\.,@?^=%&amp;:/~\+#]*[\w\-\@?^=%&amp;/~\+#])?)", RegexOptions.IgnoreCase);

            //This one seems perfect but I cant get it to work
            //Regex regx = new Regex(@"((http:\/\/ www\.| https:\/\/ www\.| http:\/\/| https:\/\/)?[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})? (\/.*)?)", RegexOptions.IgnoreCase);
            //^ (http:\/\/ www\.| https:\/\/ www\.| http:\/\/| https:\/\/)?[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})? (\/.*)?$
            #endregion

            Regex regx = new Regex(@"(?:(?:https?|ftp):\/\/)?[\w/\-?=%.]+\.[\w/\-?=%.]+", RegexOptions.IgnoreCase);

            MatchCollection mactches = regx.Matches(input);

            List<string> urls = new List<string>();

            foreach (Match match in mactches)
            {
                //input = input.Replace(match.Value, "<a href='" + match.Value + "'>" + match.Value + "</a>");
                urls.Add(match.ToString());
            }

            return urls;
        }
    }
}
