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
    public class MemberObject
    {
        public MemberObject() { }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int MemberID { get; set; }
        public string MemberName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
    public class MyMember : DbContext
    {
        public MyMember() { }
        public DbSet<MemberObject> MemberObjects { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("Assignment"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MemberObject>().Property(MemberObject => MemberObject.MemberID).IsRequired();
            modelBuilder.Entity<MemberObject>().Property(MemberObject => MemberObject.Email).IsRequired().HasMaxLength(100);// Email validation - regex needed
            modelBuilder.Entity<MemberObject>().Property(MemberObject => MemberObject.MemberName).IsRequired().HasMaxLength(40); // Name validation needed
            modelBuilder.Entity<MemberObject>().Property(MemberObject => MemberObject.City).IsRequired().HasMaxLength(15);
            modelBuilder.Entity<MemberObject>().Property(MemberObject => MemberObject.Country).IsRequired().HasMaxLength(15);
            modelBuilder.Entity<MemberObject>().Property(MemberObject => MemberObject.Password).IsRequired().HasMaxLength(30);// Password validation needed
            modelBuilder.Entity<MemberObject>().HasData(
            new MemberObject { MemberID = 1, Email = "a", MemberName = "A", City = "HCM", Country = "VN", Password = "1" },
            new MemberObject { MemberID = 2, Email = "b", MemberName = "B", City = "HN", Country = "VN", Password = "1" },
            new MemberObject { MemberID = 3, Email = "c", MemberName = "C", City = "DN", Country = "VN", Password = "1" });
            

        }
    }
}
