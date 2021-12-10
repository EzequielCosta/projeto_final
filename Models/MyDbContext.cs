using Microsoft.EntityFrameworkCore;
using democsharp.Models;

namespace projeto_final.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options){}

        public DbSet<Department> Department {get; set;}
        public DbSet<Seller> Seller {get; set;}
        public DbSet<Status> Status {get; set;}
        public DbSet<SalesRecord> SalesRecord {get; set;}


    }
}