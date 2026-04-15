using Microsoft.EntityFrameworkCore;
using BudgetApp.API.Models;

namespace BudgetApp.API.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<TransactionEntity> TransactionEntities { get; set; } = null!;
    public DbSet<Account> Accounts { get; set; } = null!;
    public DbSet<AllowedUser> AllowedUsers { get; set; } = null!;
    public DbSet<Category> Categories { get; set; } = null!;
    public DbSet<HouseholdMember> HouseholdMembers { get; set; } = null!;
    public DbSet<Household> Households { get; set; } = null!;
    public DbSet<ImportedTransaction> ImportedTransactions { get; set; } = null!;
    public DbSet<Profile> Profiles { get; set; } = null!;
    public DbSet<RecurringItem> RecurringItems { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TransactionEntity>().ToTable("transactions");
        modelBuilder.Entity<Account>().ToTable("accounts");
        modelBuilder.Entity<AllowedUser>().ToTable("allowed_users");
        modelBuilder.Entity<Category>().ToTable("categories");
        modelBuilder.Entity<HouseholdMember>().ToTable("household_members");
        modelBuilder.Entity<Household>().ToTable("households");
        modelBuilder.Entity<ImportedTransaction>().ToTable("imported_transactions");
        modelBuilder.Entity<Profile>().ToTable("profiles");
        modelBuilder.Entity<RecurringItem>().ToTable("recurring_items");

        modelBuilder.Entity<AllowedUser>().HasKey(x => x.Email);
        modelBuilder.Entity<HouseholdMember>().HasKey(x => new { x.HouseholdId, x.UserId });

        modelBuilder.Entity<ImportedTransaction>()
            .Property(x => x.TransactionTags)
            .HasColumnType("text[]");

        modelBuilder.Entity<ImportedTransaction>()
            .Property(x => x.TransactionDate)
            .HasColumnType("date");

        modelBuilder.Entity<ImportedTransaction>()
            .Property(x => x.OriginalDate)
            .HasColumnType("date");

        modelBuilder.Entity<TransactionEntity>()
            .Property(x => x.TransactionDate)
            .HasColumnType("date");
    }
}
