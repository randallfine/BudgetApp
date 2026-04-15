using System.ComponentModel.DataAnnotations.Schema;

namespace BudgetApp.API.Models;

[Table("profiles")]
public class Profile
{
    public Guid Id { get; set; }
    public string? Email { get; set; }
    public string? FullName { get; set; }
    public DateTime CreatedAt { get; set; }
}