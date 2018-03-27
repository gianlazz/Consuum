using System;
using System.Collections.Generic;
using System.Text;

namespace Consuum.Core.Models
{
    class Document
    {
        public DateTime DateTimeCreated { get; set; }
        public Image Image { get; set; }
        public TextAnnotation MyProperty { get; set; }
        public List<Url> ContainedLinks { get; set; }
    }
}
