using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BeansBurgers_v2.Models;

namespace BeansBurgers_v2.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    //public DbSet<Address> Addresses {get;set;}
    public DbSet<Burger> Burgers {get;set;}
    public DbSet<Ingredient> Ingredients {get;set;}
    public DbSet<MenuItem> MenuItems {get;set;}
    public DbSet<Order> Orders {get;set;}
    public DbSet<OrderItem> OrderItems {get;set;}
    public DbSet<PaymentInfo> PaymentInfos {get;set;}
    //public DbSet<Side> Sides {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       optionsBuilder.UseSqlServer("Server=tcp:fsd05.database.windows.net,1433;Initial Catalog=BeanBurgers;Persist Security Info=False;User ID=fsd2024350;Password=Np8dcWe4HRemkQA;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new ProductConfiguration()).Seed();
    }
}
