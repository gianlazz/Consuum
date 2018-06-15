using System;
using Microsoft.AspNetCore.Mvc;
using Consuum.DiLibrary;
using System.Threading.Tasks;

namespace api.Controllers
{
    [Route("api/[controller]")]
    public class ContactsController : Controller
    {
        // GET api/contacts
        [HttpGet]
        public IActionResult Get()
        {
            // var result = new [] {
            //     new { FirstName = "John", LastName = "Doe" },
            //     new { FirstName = "Mike", LastName = "Smith" }
            // };
            var clipboard = Dependencies.CheckoutTextReader(PlatformEnum.MacOS);
            var speech = Dependencies.CheckoutTts(PlatformEnum.MacOS);
            var lines = clipboard.GetLines();
            
            var result = new [] {
                new { Clipboard = lines[0] }
            };

            new Task(() => {
                speech.Speak(lines[0]);
            }).Start();

            return Ok(result);
        }
    }
}