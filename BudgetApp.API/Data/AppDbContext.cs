using Microsoft.EntityFrameworkCore;
using BudgetApp.API.Models;
namespace BudgetApp.API.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Transaction> Transactions { get; set; } = null!;
    // Define your DbSets here, for example:
    // public DbSet<YourEntity> YourEntities { get; set; }
}