using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;

namespace ACM.ContractApp;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<Contract> Contracts => Set<Contract>();
    
}
