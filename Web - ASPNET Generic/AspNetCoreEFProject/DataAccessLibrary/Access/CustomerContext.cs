using AspNetCoreEFProject.DataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreEFProject.DataAccessLibrary.Access
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
    }
}
