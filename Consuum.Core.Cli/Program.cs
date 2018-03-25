using System;
using System.Collections.Generic;
using Consuum.Core.Interfaces;
using Consuum.Core.Models;
using Consuum.Core.Services;

namespace Consuum.Core.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter in a string that contains urls: ");
            UrlValidationService urlValidation = new UrlValidationService();
            string userInput = Console.ReadLine();
            var urls = urlValidation.ParseForUrls(userInput);
            Console.WriteLine($"{urls.Count} urls found.");
            foreach (var url in urls)
            {
                if (urlValidation.IsValidUrl(url))
                {
                    Console.WriteLine($"{url} did connect.");
                }
                else
                {
                    Console.WriteLine($"{url} did not respond.");
                }
            }
            Console.WriteLine("Press enter to scrape valid links.");
            Console.ReadKey();
            Console.WriteLine("Scraping now...");
            WebPageContentScraperService scraper = new WebPageContentScraperService();
            List<Url> urlCollection = new List<Url>();

            foreach (var url in urls)
            {
                if (urlValidation.IsValidUrl(url))
                {
                    urlCollection.Add(new Url { Link=url, IsValid=true });
                }
            }
            foreach (var url in urlCollection)
            {
                Console.WriteLine("Scraped Contents: ");
                Console.WriteLine(scraper.Scrape(url).Text);
            }
            Console.ReadKey();
        }
    }
}
