using System;
using System.Collections.Generic;

namespace Entities
{
    public class cFile
    {
        public string FileName { get; set; }
        public string Content { get; set; }
        public List<cWord> Words { get; set; } = new List<cWord>();
    }
}
