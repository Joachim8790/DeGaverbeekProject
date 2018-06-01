using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeGaverbeekProject.Domain
{
    class WebShopDBContext : DbContext
    {
        public WebShopDBContext() : base("WebShopContext")
        {
            
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorie>().ToTable("Categorieën");
            modelBuilder.Entity<Gebruiker>().ToTable("Gebruikers");
            modelBuilder.Entity<Indeling>().ToTable("Indelingen");
            modelBuilder.Entity<Winkelmandlijn>().ToTable("Winkelmandlijnen");
            modelBuilder.Entity<Bestelling>().ToTable("Bestellingen");


        }
                    DbSet<Categorie> Categorieën { get; set; }
                    DbSet<Gebruiker> Gebruikers { get; set; }
                    DbSet<Indeling> Indelingen { get; set; }
                    DbSet<Winkelmandlijn> Winkelmandlijnen { get; set; }
                    DbSet<Bestelling> Bestellingen { get; set; }
                    
    }
}
