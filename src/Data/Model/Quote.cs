using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyQuotes.Data.Models
{
    public class Quote
    {
        [Key]
        public int QuoteId { get; set; }
        public int count { get; set; }
        public int totalCount { get; set; }
        public int lastItemIndex { get; set; }
        public Result[] results { get; set; }
    }
    public class Result
        {
            [Key]
            public string _id { get; set; }
            [NotMapped]
            public string[] tags { get; set; }
            public string content { get; set; }
            public string author { get; set; }
            public int length { get; set; }
        }
}
