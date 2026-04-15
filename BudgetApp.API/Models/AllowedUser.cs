using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BudgetApp.API.Models;

[Table("allowed_users")]
public class AllowedUser
{
    [Key]
    public string Email { get; set; } = string.Empty;
    public string Role { get; set; } = "member";
    public DateTime CreatedAt { get; set; }
}