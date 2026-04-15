using System.ComponentModel.DataAnnotations.Schema;

namespace BudgetApp.API.Models;

[Table("transactions")]
public class TransactionEntity
{
    public Guid Id { get; set; }
    public Guid HouseholdId { get; set; }
    public Guid AccountId { get; set; }
    public Guid? CategoryId { get; set; }
    public decimal Amount { get; set; }
    public DateOnly TransactionDate { get; set; }
    public string? Description { get; set; }
    public string? Notes { get; set; }
    public Guid? CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; }
}