using Consuum.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consuum.Core.Factories
{
    class ImageFactory
    {
        public static Image CreateFromBase64(string base64)
        {
            return new Image() { Base64 = base64 };
        }

        public static Image CreateFromUrl()
        {
            throw new NotImplementedException();
        }
    }
}
