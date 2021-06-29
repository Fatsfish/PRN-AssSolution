using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace BusinessObject
{
    public class MemberObject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]

        public MemberObject()
        {
            Orders = new HashSet<OrderObject>();
        }
        [Key]



        public int MemberId { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderObject> Orders { get; set; }
    }
    public class StoreContext : DbContext
    {
        public DbSet<MemberObject> MemberObjects { get; set; }
        public DbSet<ProductObject> ProductObjects { get; set; }
        public DbSet<OrderObject> OrderObjects { get; set; }
        public DbSet<OrderDetailObject> OrderDetailObjects { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("Assignment"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MemberObject>().Property(MemberObject => MemberObject.MemberId);
            modelBuilder.Entity<MemberObject>().Property(MemberObject => MemberObject.Email).IsRequired().HasMaxLength(100);// Email validation - regex needed
            modelBuilder.Entity<MemberObject>().Property(MemberObject => MemberObject.CompanyName).IsRequired().HasMaxLength(40); // Name validation needed
            modelBuilder.Entity<MemberObject>().Property(MemberObject => MemberObject.City).IsRequired().HasMaxLength(15);
            modelBuilder.Entity<MemberObject>().Property(MemberObject => MemberObject.Country).IsRequired().HasMaxLength(15);
            modelBuilder.Entity<MemberObject>().Property(MemberObject => MemberObject.Password).IsRequired().HasMaxLength(30);// Password validation needed
            modelBuilder.Entity<MemberObject>().HasData(
            new MemberObject { MemberId = 1, Email = "a", CompanyName = "A", City = "HCM", Country = "VN", Password = "1" },
            new MemberObject { MemberId = 2, Email = "b", CompanyName = "B", City = "HN", Country = "VN", Password = "1" },
            new MemberObject { MemberId = 3, Email = "c", CompanyName = "C", City = "DN", Country = "VN", Password = "1" });



            modelBuilder.Entity<ProductObject>().Property(ProductObject => ProductObject.CategoryId).IsRequired();
            modelBuilder.Entity<ProductObject>().Property(ProductObject => ProductObject.ProductName).IsRequired().HasMaxLength(40);
            modelBuilder.Entity<ProductObject>().Property(ProductObject => ProductObject.Weight).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<ProductObject>().Property(ProductObject => ProductObject.UnitPrice).IsRequired();
            modelBuilder.Entity<ProductObject>().Property(ProductObject => ProductObject.UnitsInStock).IsRequired();
            modelBuilder.Entity<ProductObject>().HasData(
            new ProductObject { CategoryId = 1, ProductName = "Laptops", Weight = "20kg", UnitPrice = 10000, UnitsInStock = 10 },
            new ProductObject { CategoryId = 1, ProductName = "PCs", Weight = "25kg", UnitPrice = 10000, UnitsInStock = 9 },
            new ProductObject { CategoryId = 1, ProductName = "Phones", Weight = "25kg", UnitPrice = 10000, UnitsInStock = 1 });



            modelBuilder.Entity<OrderObject>().Property(OrderObject => OrderObject.OrderID).IsRequired();
            modelBuilder.Entity<OrderObject>().Property(OrderObject => OrderObject.MemberID).IsRequired();// reference MemberObject
            modelBuilder.Entity<OrderObject>().Property(OrderObject => OrderObject.OrderDate).IsRequired();// check date validation needed
            modelBuilder.Entity<OrderObject>().Property(OrderObject => OrderObject.RequiredDate);// check date validation needed
            modelBuilder.Entity<OrderObject>().Property(OrderObject => OrderObject.ShippedDate);// check date validation needed
            modelBuilder.Entity<OrderObject>().Property(OrderObject => OrderObject.Freight).IsConcurrencyToken();
            modelBuilder.Entity<OrderObject>().HasData(
            new OrderObject { OrderID = 1, MemberID = 1, OrderDate = System.DateTime.Now },
            new OrderObject { OrderID = 2, MemberID = 1, OrderDate = System.DateTime.Now },
            new OrderObject { OrderID = 3, MemberID = 1, OrderDate = System.DateTime.Now });



            modelBuilder.Entity<OrderDetailObject>().Property(OrderDetailObject => OrderDetailObject.OrderId).IsRequired(); //reference OrderObject
            modelBuilder.Entity<OrderDetailObject>().Property(OrderDetailObject => OrderDetailObject.ProductId).IsRequired();// reference ProductObject
            modelBuilder.Entity<OrderDetailObject>().Property(OrderDetailObject => OrderDetailObject.UnitPrice).IsRequired().IsConcurrencyToken();// reference ProductObject
            modelBuilder.Entity<OrderDetailObject>().Property(OrderDetailObject => OrderDetailObject.Quantity).IsRequired();
            modelBuilder.Entity<OrderDetailObject>().Property(OrderDetailObject => OrderDetailObject.Discount).IsRequired();
            modelBuilder.Entity<OrderDetailObject>().HasData(
            new OrderDetailObject { OrderId = 1, ProductId = 1, UnitPrice = 1, Quantity = 1, Discount = 10 }, // TBD
            new OrderDetailObject { OrderId = 2, ProductId = 1, UnitPrice = 1, Quantity = 1, Discount = 10 }, // TBD 
            new OrderDetailObject { OrderId = 3, ProductId = 1, UnitPrice = 1, Quantity = 1, Discount = 10 });// TBD


        }
    }
}
