using Abc.Northwind.Entites.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Abc.Northwind.DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Server=127.0.0.1;Port=5432;Database=Northwind;User Id=postgres;
Password=163020;");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}