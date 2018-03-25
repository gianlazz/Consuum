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
            Console.WriteLine($"{urlValidation.ParseForUrls(Console.ReadLine()).Count} urls found.");

            Console.ReadKey();
        }
    }
}
