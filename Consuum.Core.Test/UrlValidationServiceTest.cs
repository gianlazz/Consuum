using NUnit.Framework;
using System;
using Consuum.Core.Services;
using Consuum.Core.Interfaces;
using Consuum.Core.Models;

namespace Consuum.Core.Test
{
    [TestFixture]
    public class UrlValidationServiceTest
    {
        #region Testing Consts
        //Simple Url Variables
        private const string SingleValidUrl = "http://google.com";
        private const string SingleInvalidUrl = "http://asdfasljasdkjlfakjhaskjhkhjaskjhfkjkaskhjhkja.com";
        //Moderately Challenging Url Variables
        private const string ValidUrls = "http://google.com google.com www.google.com https://google.com";
        private const string InvalidUrls = ""; //partial urls or urls that don't resolve to real sites
        //Complex Url Variables
        private const string ValidAndInvalidUrls = "";
        private const string OcrOutputWithValidUrls = "";
        private const string OcrOutputWithInvalidUrls = "";
        private const string OcrOutputWithValidAndInvalidUrls = "";
        #endregion

        [Test]
        public void CheckForUrls_AcceptsString_ReturnsIntToSignifyFoundUrls()
        {
            //Arrange
            UrlValidationService urlValidationService = new UrlValidationService();

            //Act
            int results = urlValidationService.CheckForUrls("and example of ocr text that contains urls");

            //Assert
            Assert.That(results <= 0);

        }

        [Test]
        public void ParseForUrls_AcceptsString_ReturnsPossibleUrls()
        {
            //Arrange
            UrlValidationService urlValidationService = new UrlValidationService();

            //Act
            urlValidationService.ParseForUrls("and example of ocr text that contains urls");

            //Assert

        }

        [Test]
        public void ValidateUrl_ValidUrl_ShouldReturnUrlMarkedAsInvalid()
        {

        }

        [Test]
        /* I imagine this using google or some kind of third party search service which will probably
         * require an interface and dependency injection to fulfill so I'm not bound by specific solutions.
         */
        
        public void AttemptToFixPartialUrls_AcceptsListOfUrls_ReturnsIntToSignifyHowManyWereFixed()
        {

        }
    }
}
