using System;
using System.Collections.Generic;
using System.Text;

namespace Consuum.Domain.Models
{
    public class TextAnnotation
    {
        public string Text { get; set; }
        public List<Url> ContainedLinks { get; set; }

        public TextAnnotation()
        {
            ContainedLinks = new List<Url>();
        }
    }
}
