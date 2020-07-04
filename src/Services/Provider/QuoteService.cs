using DailyQuotes.Data.Models;
using DailyQuotes.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyQuotes.Services.Provider
{
    class QuoteService : IQuoteService
    {
        public Task<IEnumerable<Quote>> FetchQuotesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> PersistQuotesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Quote> RefreshQuoteAsync()
        {
            throw new NotImplementedException();
        }
    }
}
