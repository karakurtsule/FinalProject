using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework 
{
    //Context: Db tabloları ile proje classlarını baglamak
    public class NorthwindContext: DbContext   // entity frameworkteki DbContext
    {
        //Projemizin hangi veri tabanı ile ilişkili olduğunu gösteriyoruz. hangi veritabanına baglandıgımızı söylüyoruz.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\MSSQLLocalDB; Database = Northwind; Trusted_Connection = true");
        }

        //Hangi nesnem hangi veritabanı tablosuna denk geldigini söylüyoruz.
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
