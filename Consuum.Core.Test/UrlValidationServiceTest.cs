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
        private const string ValidUrls = "http://google.com google.com www.google.com https://google.com";
        private const string InvalidUrls = ""; //partial urls or urls that don't resolve to real sites
        private const string ValidAndInvalidUrls = "";
        private const string OcrOutputWithValidUrls = "";
        private const string OcrOutputWithInvalidUrls = "";
        private const string OcrOutputWithValidAndInvalidUrls = "";

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
    }
}
