using DailyQuotes.Data.Models;
using DailyQuotes.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DailyQuotes.Services.Provider
{
    public class NetworkService : INetworkService
    {
         
        public static readonly HttpClient httpClient;
        static NetworkService()
        {
            httpClient = new HttpClient();
        }

        /// <summary>
        /// Check if user has an internet connection
        /// </summary>
        /// <returns>bool</returns>
        static async Task<bool> IsInternetConnectedAsync()
        {
            var result = await httpClient.GetAsync(Resources.bingUrl);
            if (result.IsSuccessStatusCode)
                return true;
            return false;
        }
    }
}
