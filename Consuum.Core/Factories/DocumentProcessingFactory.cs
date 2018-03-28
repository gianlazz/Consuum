using Consuum.Core.ConfigurationSettings;
using Consuum.Core.Models;
using Consuum.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consuum.Core.Factories
{
    class DocumentProcessingFactory
    {
        public Document Create(string input, InputType inputType)
        {
            Document document = new Document();
            
            //Hydrates the json setting file incase it dictates rules
            //on how the Document should be created
            ConsuumSettings settings = SettingsDeserializer.Hydrate();

            /* From here I call all of the other services
             * as I construct the document?
             * 
             */
            //var text = new TextAnnotation();
            //var urls = new UrlValidationService();
            switch (inputType)
            {
                case InputType.WebPageUrl:
                    
                    break;
                case InputType.ImageFromBase64:
                    document.Image = ImageFactory.CreateFromBase64(input);
                    //(settings.UrlParsingSettings.ParseForUrls) ? UrlValidationService: ;
                    break;
                case InputType.Text:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    //Text
                    break;
            }

            /* Have logic for the different ways to create
             * a document including
             * url
             * image
             * text
             * other?
             * 
             * from those paths consult with the ConsuumSettings
             * deserialized from the json
             */

            return document;
        }
    }
}
