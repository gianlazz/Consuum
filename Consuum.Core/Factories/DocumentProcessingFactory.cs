using Consuum.Core.ConfigurationSettings;
using Consuum.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consuum.Core.Factories
{
    class DocumentProcessingFactory
    {
        public Document Create()
        {
            Document document = new Document();

            //ConsuumSettings settings = SettingsDeserializer

            /* From here I call all of the other services
             * as I construct the document?
             * 
             */
            //var settings = new ConsuumSettingsService();
            //var image = new ImageService();
            //var text = new TextAnnotation();
            //var urls = new UrlValidationService();

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
