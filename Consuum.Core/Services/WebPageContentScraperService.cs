using Consuum.Core.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace Consuum.Core.Services
{
    public class WebPageContentScraperService
    {
        public TextAnnotation Scrape(Url url)
        {
            /* By this time it should be assumed that the webpage is valid.
             * 
             * Through some porocess it should go to the site and pull all
             * reading content.
             * 
             * Ideally this would not include adds or navigational content,
             * instead it would contain only the body of the page.
             * 
             * Duhh... Okay pull all text from the body...
             */

            //return webBrowser1.Document.Body.InnerText;

            var client = new WebClient();
            var content = client.DownloadString(url.Link);

            //if (webBrowser1.Document != null)
            //{
            //    HtmlElement elem = webBrowser1.Document.CreateElement("A");
            //    elem.SetAttribute("HREF", url);
            //    elem.InnerText = "Visit our Web site for more details.";

            //    webBrowser1.Document.Body.AppendChild(elem);
            //}

            //using (HttpClient client = new HttpClient())
            //{
            //    using (HttpResponseMessage response = client.GetAsync(url).Result)
            //    {
            //        using (HttpContent content = response.Content)
            //        {
            //            //string result = content.ReadAsStringAsync().Result;
            //            string result = content.ReadAsStringAsync().Result;

            //        }
            //    }
            //}

            //XmlDocument document = new XmlDocument();
            //document.Load(url.Link);
            //string allText = document.InnerText;
            content = content.Substring(content.IndexOf("<body"));
            //content = content.Substring(content.LastIndexOf("</body>"));

            Regex regex = new Regex("\\<[^\\>]*\\>");

            content = regex.Replace(content, String.Empty);

            return new TextAnnotation() { Text = content };
        }
    }
}
