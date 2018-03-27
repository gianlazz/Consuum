using Consuum.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consuum.Core.Services
{
    class DocumentProcessingService
    {
        public Document Create()
        {
            Document document = new Document();

            /* From here I call all of the other services
             * as I construct the document?
             * 
             */
            //var settings = new ConsuumSettingsService();
            //var image = new ImageService();
            //var text = new TextAnnotation();
            //var urls = new UrlValidationService();

            return document;
        }
    }
}
