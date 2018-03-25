using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Consuum.Core.Interfaces;
using Consuum.Core.Models;
using Consuum.Core.Services;

namespace Consuum.Core.Test
{
    [TestFixture]
    [Category("WebPageScraper")]
    class WebPageScraperServiceTest
    {
        [Test]
        /*This also relies on external network dependencies making it not a proper
         * Unit test and more of an integration test.
         * So I would probably need to mock the networking interface it uses with
         * dependency Injection.
         * 
         * Will have to look into mocking WebClient. However I could just take the
         * results scraped from a page and inject that as a const. Then test against
         * any logic there may be for stripping just the reading content? Seems like
         * a good idea. Since that's really where any custom business logic will be.
         * 
         * Right now I'm really just testing microsofts code in integration with my
         * objects which isn't exactly proper.
         */
        public void Scrape_ProcessesValidatedUrls_ReturnsTextAnnotation()
        {
            //Arrange
            WebPageContentScraperService scraperService = new WebPageContentScraperService();
            Url url = new Url() { IsValid=true, Link= "https://en.wikipedia.org/wiki/Piracetam" };

            //Act
            TextAnnotation textAnnotation = scraperService.Scrape(url);

            //Assert
            Assert.That(textAnnotation.Text.Contains("Piracetam"));
        }
    }
}
