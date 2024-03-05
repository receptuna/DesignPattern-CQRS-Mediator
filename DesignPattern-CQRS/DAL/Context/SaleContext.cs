using DesignPattern_CQRS.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern_CQRS.DAL.Context
{
    public class SaleContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=RECOBABADB\\SQLEXPRESS01; initial catalog=DbSatis; integrated security=true");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers{ get; set; }
    }
}
