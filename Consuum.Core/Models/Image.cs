using System;
using System.Collections.Generic;
using System.Text;

namespace Consuum.Core.Models
{
    public class Image
    {
        public string Base64 { get; set; }
        public TextAnnotation Content { get; set; }
    }
}
