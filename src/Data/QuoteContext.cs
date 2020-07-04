using DailyQuotes.Data.Dto;
using DailyQuotes.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyQuotes.Data
{
    public class QuoteContext: DbContext
    {
        private static bool _created = false;
        public QuoteContext()
        {
            if (!_created)
            {
                _created = true;
                try
                {
                    Database.MigrateAsync();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {
            optionbuilder.UseSqlite("Data Source = Quotes.db");
            //optionbuilder.UseSqlite(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);
        }
        public virtual DbSet<Quote> Quotes { get; set; }
    }
}
