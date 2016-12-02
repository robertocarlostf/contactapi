using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ContactForm.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(): base("TicketsDB")
        {
        }

        public ContactContext(string ConnString): base(ConnString)
        {
        }

        public DbSet<ContactForm> Tickets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}