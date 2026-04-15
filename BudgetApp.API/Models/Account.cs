using System.ComponentModel.DataAnnotations.Schema;

namespace BudgetApp.API.Models;

[Table("accounts")]
public class Account
{
    public Guid Id { get; set; }
    public Guid HouseholdId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public string? Institution { get; set; }
    public decimal StartingBalance { get; set; }
    public DateTime CreatedAt { get; set; }
}