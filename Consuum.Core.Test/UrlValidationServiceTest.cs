using NUnit.Framework;
using System;
using System.Collections.Generic;
using Consuum.Core.Models;

namespace Consuum.Core.Test
{
    [TestFixture]
    public class UrlValidationServiceTest
    {
        #region Testing Consts
        //Simple Url Variables
        private const string ValidHttpLink = "http://google.com";
        private const string ValidHttpsLink = "https://google.com";
        private const string ValidWwwLink = "www.google.com";
        private const string ValidLinkWithoutPrefix = "google.com";
        private const string AllSimpleUrls = "https://www.google.com http://www.google.com https://google.com http://google.com www.google.com google.com";
        //Moderately Challenging Url Variables
        private const string SingleInvalidUrl = "http://asdfasljasdkjlfakjhaskjhkhjaskjhfkjkaskhjhkja.com";
        private const string InvalidUrls = ""; //partial urls or urls that don't resolve to real sites
        //Complex Url Variables
        private const string ValidAndInvalidUrls = "";
        private const string OcrOutputWithValidUrls = "";
        private const string OcrOutputWithInvalidUrls = "";
        private const string OcrOutputWithValidAndInvalidUrls = "";
        #endregion

        [Test]
        public void CheckForUrls_Pass1ValidHttpLink_FindsAndReturnsIntCountOf1()
        {
            //Arrange
            UrlValidationService urlValidationService = new UrlValidationService();
            int count = 0;

            //Act
            urlValidationService.ParseForUrls(ValidHttpLink, out count);

            //Assert
            Assert.AreEqual(1, count);
        }

        [Test]
        public void CheckForUrls_Pass1ValidHttpsLink_FindsAndReturnsIntCountOf1()
        {
            //Arrange
            UrlValidationService urlValidationService = new UrlValidationService();
            int count = 0;

            //Act
            urlValidationService.ParseForUrls(ValidHttpsLink, out count);

            //Assert
            Assert.AreEqual(1, count);
        }

        [Test]
        public void CheckForUrls_PassValidWwwLink_FindsAndReturnsIntCountOf1()
        {
            //Arrange
            UrlValidationService urlValidationService = new UrlValidationService();
            int count = 0;

            //Act
            urlValidationService.ParseForUrls(ValidWwwLink, out count);

            //Assert
            Assert.AreEqual(1, count);
        }

        [Test]
        public void CheckForUrls_ValidLinkWithoutPrefix_FindsAndReturnsIntCountOf1()
        {
            //Arrange
            UrlValidationService urlValidationService = new UrlValidationService();
            int count = 0;

            //Act
            urlValidationService.ParseForUrls(ValidLinkWithoutPrefix, out count);

            //Assert
            Assert.AreEqual(1, count);
        }

        [Test]
        public void CheckForUrls_AllSimpleUrls_FindsAndReturnsIntCountOf_4()
        {
            //Arrange
            UrlValidationService urlValidationService = new UrlValidationService();
            int count = 0;


            //Act
            urlValidationService.ParseForUrls(AllSimpleUrls, out count);

            //Assert
            Assert.AreEqual(6, count);
        }

        [Test]
        public void CheckForUrls_AllSimpleUrlsWithoutSpaces_FindsAndReturnsIntCountOf_4()
        {
            //Arrange
            UrlValidationService urlValidationService = new UrlValidationService();
            int count = 0;

            //Act
            urlValidationService.ParseForUrls($"{ValidHttpLink}{ValidHttpsLink}{ValidWwwLink}{ValidLinkWithoutPrefix}", out count);

            //Assert
            Assert.AreEqual(4, count);
        }

        [Test]
        public void CheckForUrls_AllSimpleUrlsWithoutSpaces_FindsAndReturnsIntCountOf_6()
        {
            //Arrange
            UrlValidationService urlValidationService = new UrlValidationService();
            int count = 0;

            //Act
            urlValidationService.ParseForUrls($"{AllSimpleUrls.Trim(' ')}", out count);

            //Assert
            Assert.AreEqual(6, count);
        }

        // Might this be breaking the rule of unit testing by not mocking
        // the external networking dependencies, so this test could fail
        // even though the code is good, just if the internet isn't working...
        // So that kind of makes it an integration test until I mock it, or
        // setup some kind of DI for networking
        [Test]
        public void IsValidUrl_ValidHttpLink_ReturnsTrue()
        {
            //Arrange
            UrlValidationService urlValidationService = new UrlValidationService();

            //Act
            bool didConnect = urlValidationService.IsValidUrl(ValidHttpLink);

            //Assert
            Assert.AreEqual(true, didConnect);
        }

        [Test]
        public void IsValidUrl_AllSimpleUrls_ReturnsTrue()
        {
            //Arrange
            UrlValidationService urlValidationService = new UrlValidationService();
            List<string> urls = new List<string>();
            int didConnectCounter = 0;

            //Act
            urls = urlValidationService.ParseForUrls(AllSimpleUrls);
            foreach (var url in urls)
            {
                if (urlValidationService.IsValidUrl(url))
                {
                    didConnectCounter++;
                }
            }
            

            //Assert
            Assert.AreEqual(6, didConnectCounter);
        }

        //[Test]
        //public void ParseForUrls_AcceptsString_ReturnsPossibleUrls()
        //{
        //    //Arrange
        //    UrlValidationService urlValidationService = new UrlValidationService();

        //    //Act
        //    urlValidationService.ParseForUrls("and example of ocr text that contains urls");

        //    //Assert

        //}

        //[Test]
        //public void ValidateUrl_ValidUrl_ShouldReturnUrlMarkedAsInvalid()
        //{

        //}

        //[Test]
        ///* I imagine this using google or some kind of third party search service which will probably
        // * require an interface and dependency injection to fulfill so I'm not bound by specific solutions.
        // */

        //public void AttemptToFixPartialUrls_AcceptsListOfUrls_ReturnsIntToSignifyHowManyWereFixed()
        //{

        //}
    }
}
