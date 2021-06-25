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
    public class OrderObject
    {
        public OrderObject() { }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { get; set; }
        public int MemberID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public Double Freight { get; set; }
    }
    public class MyOrder : DbContext
    {
        public MyOrder() { }
        public DbSet<OrderObject> OrderObjects { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("Assignment"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderObject>().Property(OrderObject => OrderObject.OrderID).IsRequired();
            modelBuilder.Entity<OrderObject>().Property(OrderObject => OrderObject.MemberID).IsRequired();// reference MemberObject
            modelBuilder.Entity<OrderObject>().Property(OrderObject => OrderObject.OrderDate).IsRequired();// check date validation needed
            modelBuilder.Entity<OrderObject>().Property(OrderObject => OrderObject.RequiredDate);// check date validation needed
            modelBuilder.Entity<OrderObject>().Property(OrderObject => OrderObject.ShippedDate);// check date validation needed
            modelBuilder.Entity<OrderObject>().Property(OrderObject => OrderObject.Freight).IsConcurrencyToken();
            modelBuilder.Entity<OrderObject>().HasData(
            new OrderObject { OrderID = 1, MemberID = 1, OrderDate = System.DateTime.Now},
            new OrderObject { OrderID = 2, MemberID = 1, OrderDate = System.DateTime.Now },
            new OrderObject { OrderID = 3, MemberID = 1, OrderDate = System.DateTime.Now });

        }
    }
}
