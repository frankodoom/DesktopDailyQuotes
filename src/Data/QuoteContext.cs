using DailyQuotes.Data.Model;
using DailyQuotes.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;

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

                    //Debugger.Log(ex);
                }
                
            }
        }
#pragma warning disable S927 // parameter names should match base declaration and other partial definitions
        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
#pragma warning restore S927 // parameter names should match base declaration and other partial definitions
        {
            optionbuilder.UseSqlite("Data Source = Quotes.db");
            //optionbuilder.UseSqlite(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);
        }
        public virtual DbSet<Quote> Quotes { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
    }
}
