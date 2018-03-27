using System;
using System.Collections.Generic;
using System.Text;

namespace Consuum.Core.Models
{
    public class TextAnnotation
    {
        /* Should ultimately organize content into
         * pages, paragraphs, and words. All of which
         * should retain x&y coordinates if att all possible
         * for re-rendering.
         * 
         * It would be nice to also have the associated Image
         * object from which it was created. That way I could
         * overlay the words scanned over the original image
         * for cool animations or renderings of the reading process.
         */
        public string Text { get; set; }
    }
}
