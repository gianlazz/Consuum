using System;
using System.Collections.Generic;
using System.Text;

namespace Consuum.Domain.Models
{
    public class Image
    {
        public string Base64 { get; set; }
        public TextAnnotation Content { get; set; }
    }
}
