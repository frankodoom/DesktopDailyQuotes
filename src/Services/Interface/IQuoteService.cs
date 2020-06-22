using DailyQuotes.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyQuotes.Services.Interface
{
    interface IQuoteService
    {
        /// <summary>
        /// Fetches new Quotes from the Quote Api
        /// </summary>
        /// <returns> Returns IEnumerable<Quotes>  </returns>
        Task<IEnumerable<Quotes>> FetchQuotesAsync();
        /// <summary>
        ///  Persists the newly fetched quotes in the applications Datastore
        /// </summary>
        /// <returns> Returns true when successful, false when unsuccessful</returns>
        Task<bool> PersistQuotesAsync();

        /// <summary>
        /// Manually cycle through the persisted quotes to display on Desktop
        /// </summary>
        /// <returns>Returns a new Quote</returns>
        Task<Quotes> RefreshQuoteAsync();
    }
}
