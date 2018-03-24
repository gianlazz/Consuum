using System;
using System.Collections.Generic;
using System.Text;
using Consuum.Core.Interfaces;

namespace Consuum.Core
{
    class ImageService
    {
        private readonly IImageDirectoryService _ImageDirectoryService;
        private readonly IImageBase64Service _ImageBase64Service;

        public ImageService(IImageDirectoryService imageDirectoryService, IImageBase64Service imageBase64Service)
        {
            _ImageDirectoryService = imageDirectoryService;
            _ImageBase64Service = imageBase64Service;
        }
    }
}
