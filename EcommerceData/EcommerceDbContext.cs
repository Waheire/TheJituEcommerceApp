using EcommerceDomain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceData
{
    public class EcommerceDbContext : DbContext
    {
       
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<Order> Orders { get; set; }


        //connect to sql server
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
              "Server=FRUIT; Database=TheJituEcomerceApp; User Id=sa; Password=fru1t; Encrypt=False; TrustServerCertificate=True"
               );
            //optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = PubDb");
        }

        //create relationships
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne(u => u.Cart)
                .WithOne(c => c.User)
                .HasForeignKey<Cart>(c => c.Id);

            // Other configurations...

            base.OnModelCreating(modelBuilder);
        }




    }
}
