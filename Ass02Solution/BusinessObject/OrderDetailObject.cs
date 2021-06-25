using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace BusinessObject
{
    public class OrderDetailObject
    {
        [Key]
        public int OrderID { get; set; }
        [Key]
        public int ProductID { get; set; }
        public Double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public float Discount { get; set; }

    }
    public class MyOrderDetail : DbContext
    {
        public MyOrderDetail() { }
        public DbSet<OrderDetailObject> orderDetailObjects { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("Assignment"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetailObject>().Property(OrderDetailObject => OrderDetailObject.OrderID).IsRequired(); //reference OrderObject
            modelBuilder.Entity<OrderDetailObject>().Property(OrderDetailObject => OrderDetailObject.ProductID).IsRequired();// reference ProductObject
            modelBuilder.Entity<OrderDetailObject>().Property(OrderDetailObject => OrderDetailObject.UnitPrice).IsRequired().IsConcurrencyToken();// reference ProductObject
            modelBuilder.Entity<OrderDetailObject>().Property(OrderDetailObject => OrderDetailObject.Quantity).IsRequired();
            modelBuilder.Entity<OrderDetailObject>().Property(OrderDetailObject => OrderDetailObject.Discount).IsRequired();
            modelBuilder.Entity<OrderDetailObject>().HasData(
            new OrderDetailObject { OrderID = 1, ProductID = 1, UnitPrice = 1, Quantity=1, Discount = 10}, // TBD
            new OrderDetailObject { OrderID = 2, ProductID = 1, UnitPrice = 1, Quantity = 1, Discount = 10 }, // TBD 
            new OrderDetailObject { OrderID = 3, ProductID = 1, UnitPrice = 1, Quantity = 1, Discount = 10 });// TBD

        }
    }
