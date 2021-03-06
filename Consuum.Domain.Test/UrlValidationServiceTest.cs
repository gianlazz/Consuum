﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using Consuum.Domain.Models;

namespace Consuum.Domain.Test
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

        // [Test]
        // public void ParseForUrls_AcceptsString_ReturnsPossibleUrls()
        // {
        //    //Arrange
        //    UrlValidationService urlValidationService = new UrlValidationService();

        //    //Act
        //    urlValidationService.ParseForUrls("and example of ocr text that contains urls");

        //    //Assert

        // }

        // [Test]
        // public void ValidateUrl_ValidUrl_ShouldReturnUrlMarkedAsInvalid()
        // {

        // }

        // [Test]
        // /* I imagine this using google or some kind of third party search service which will probably
        // * require an interface and dependency injection to fulfill so I'm not bound by specific solutions.
        // */

        // public void AttemptToFixPartialUrls_AcceptsListOfUrls_ReturnsIntToSignifyHowManyWereFixed()
        // {

        // }
    }
}
