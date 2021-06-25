using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObject
{
    public class ProductObject
    {
        public ProductObject() { }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public string Weight { get; set; }

        public decimal UnitPrice { get; set; }

        public int UnitsInStock { get; set; }

    }
    public class MyStock: DbContext
    {
        public MyStock() { }
        public DbSet<ProductObject> ProductObjects { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("Assignment"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductObject>().Property(ProductObject => ProductObject.CategoryID).IsRequired();
            modelBuilder.Entity<ProductObject>().Property(ProductObject => ProductObject.ProductName).IsRequired().HasMaxLength(40);
            modelBuilder.Entity<ProductObject>().Property(ProductObject => ProductObject.Weight).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<ProductObject>().Property(ProductObject => ProductObject.UnitPrice).IsRequired();
            modelBuilder.Entity<ProductObject>().Property(ProductObject => ProductObject.UnitsInStock).IsRequired();
            modelBuilder.Entity<ProductObject>().HasData(
            new ProductObject { CategoryID = 1, ProductID = 1, ProductName = "Laptops", Weight = "20kg", UnitPrice = 10000, UnitsInStock = 10 },
            new ProductObject { CategoryID = 1, ProductID = 2, ProductName = "PCs", Weight = "25kg", UnitPrice = 10000, UnitsInStock = 9 },
            new ProductObject { CategoryID = 1, ProductID = 3, ProductName = "Phones", Weight = "25kg", UnitPrice = 10000, UnitsInStock = 1 });

        }
    }
}
