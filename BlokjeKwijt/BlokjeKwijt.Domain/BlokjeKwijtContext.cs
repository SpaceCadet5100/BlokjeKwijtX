using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlokjeKwijt.Domain
{
    public class BlokjeKwijtContext : DbContext
    {
        public DbSet<User> Users { get;set; }
        public DbSet<Blokje> Blokjes { get; set; }
        public DbSet<ContactForm> ContactForms { get; set; }
        public DbSet<BlokjeColor> BlokjeColors { get; set; }
        public DbSet<UserHasExtraBrick> UserHasExtraBricks { get; set; }
        public DbSet<UserHasMissingBrick> UserHasMissingBricks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=BlokjeKwijtDB;Trusted_Connection=True;");
            }
        }
    }
}
