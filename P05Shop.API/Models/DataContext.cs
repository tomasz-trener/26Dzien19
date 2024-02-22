using Microsoft.EntityFrameworkCore;
using P06Shop.Shared;
using P07Shop.DataSeeder;

namespace P05Shop.API.Models
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
             
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             //konfigurujemy przy pomocy fluent api 
             // sposób mapowania relacji między tabelami
             // oraz dodatkowe właściwości kolumn

            modelBuilder.Entity<Product>()
                .Property(p => p.Barcode)
                .IsRequired()
                .HasMaxLength(12);

            modelBuilder.Entity<Product>()
                .Property(p=>p.Title)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Product>()
                .Property(p=>p.Price)
                .HasColumnType("decimal(8,2)");

            //modelBuilder.Entity<Product>()
            //    .HasKey(p=>p.Code); // domyślnie kluczem głównym jest pole Id

            modelBuilder.Entity<Product>()
                .HasData(ProductDataSeeder.GenerateProductData());
                 

        }
    }
}
