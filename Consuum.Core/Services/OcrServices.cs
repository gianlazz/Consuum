using System;
using System.Collections.Generic;
using System.Text;
using Consuum.Core.Models;

namespace Consuum.Core.Services
{
    class OcrServices : IOcrService
    {
        private readonly IOcrService _ocrService;

        public OcrServices(IOcrService ocrService)
        {
            _ocrService = ocrService;
        }

        public TextAnnotation Parse(Image image)
        {
            var result = _ocrService.Parse(image);
            return result;
        }
    }
}
