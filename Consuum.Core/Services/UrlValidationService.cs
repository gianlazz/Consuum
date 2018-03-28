using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using Consuum.Core.Models;

namespace Consuum.Core.Services
{
    public class UrlValidationService
    {

        public static List<string> ParseForUrls(string input)
        {
            return UrlRegex(input);
        }

        public static List<string> ParseForUrls(string input, out int numberFound)
        {
            var result = UrlRegex(input);
            numberFound = result.Count;

            return result;
        }

        public static bool IsValidUrl(string url)
        {
            /* Should have some kind of error handeling
             * if there's no connectivity.
             * 
             * It would then be nice to go back over and re-evaluate
             * all of the urls once there is connectivity to then 
             * resolve which ones respond or timeout.
             * 
             * Ultimately all Urls should be marked as valid, invalid, or possible
             * or something to that effect.
             */

            #region Notes about solving absolutepath exception on WebRequest.Create()
            //Uri uri;
            //var UriDidSucceed = Uri.TryCreate(url, UriKind.RelativeOrAbsolute, out uri);

            // This doesn't handle urls without http:// or https:// in the beginning
            // I'll probably have to do something about it.
            // Maybe I should use Uri.TryParse(); ?
            #endregion

            //If path is relitive make it absolute
            //for WebRequest.Create()
            if (!url.Contains("http"))
            {
                url = $"https://{url}";
            }

            WebRequest webRequest = WebRequest.Create(url);
            WebResponse webResponse;
            try
            {
                webResponse = webRequest.GetResponse();
            }
            catch //If exception thrown then couldn't get response from address
            {
                return false;
            }
            return true;
        }

        private static List<string> UrlRegex(string input)
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
