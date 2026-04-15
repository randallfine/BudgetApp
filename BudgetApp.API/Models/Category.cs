using System.ComponentModel.DataAnnotations.Schema;

namespace BudgetApp.API.Models;

[Table("categories")]
public class Category
{
    public Guid Id { get; set; }
    public Guid HouseholdId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Kind { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
}