using System;

namespace Consuum.IntegrationTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Attempting to run integration tests");
        }

        // // Might this be breaking the rule of unit testing by not mocking
        // // the external networking dependencies, so this test could fail
        // // even though the code is good, just if the internet isn't working...
        // // So that kind of makes it an integration test until I mock it, or
        // // setup some kind of DI for networking
        // [Test]
        // public void IsValidUrl_ValidHttpLink_ReturnsTrue()
        // {
        //     //Arrange
        //     UrlValidationService urlValidationService = new UrlValidationService();

        //     //Act
        //     bool didConnect = urlValidationService.IsValidUrl(ValidHttpLink);

        //     //Assert
        //     Assert.AreEqual(true, didConnect);
        // }

        // [Test]
        // public void IsValidUrl_AllSimpleUrls_ReturnsTrue()
        // {
        //     //Arrange
        //     UrlValidationService urlValidationService = new UrlValidationService();
        //     List<string> urls = new List<string>();
        //     int didConnectCounter = 0;

        //     //Act
        //     urls = urlValidationService.ParseForUrls(AllSimpleUrls);
        //     foreach (var url in urls)
        //     {
        //         if (urlValidationService.IsValidUrl(url))
        //         {
        //             didConnectCounter++;
        //         }
        //     }
            

        //     //Assert
        //     Assert.AreEqual(6, didConnectCounter);
        // }

    }
}
