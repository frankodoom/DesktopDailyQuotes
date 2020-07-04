using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyQuotes.Data.Dto
{
    public class QuoteDto
    {
        public string _id { get; set; }
        public string content { get; set; }
        public string author { get; set; }
        public int length { get; set; }
    }
}
