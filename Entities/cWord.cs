using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class cWord
    {
        public string Value { get; set; }
        public int Count { get; set; }
        public int Length { get; set; }
    }
}
