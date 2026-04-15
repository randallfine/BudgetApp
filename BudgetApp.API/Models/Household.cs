using System.ComponentModel.DataAnnotations.Schema;

namespace BudgetApp.API.Models;

[Table("households")]
public class Household
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
}