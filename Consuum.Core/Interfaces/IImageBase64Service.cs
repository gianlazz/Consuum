using Consuum.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consuum.Core.Interfaces
{
    interface IImageBase64Service
    {
        Image CreateFromBase64(string base64);
    }
}
