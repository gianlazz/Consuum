using System;
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
            int didConnectCounter = 0;
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
            Console.ReadKey();
        }
    }
}
