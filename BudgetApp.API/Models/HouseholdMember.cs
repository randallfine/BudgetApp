using System.ComponentModel.DataAnnotations.Schema;

namespace BudgetApp.API.Models;

[Table("household_members")]
public class HouseholdMember
{
    public Guid HouseholdId { get; set; }
    public Guid UserId { get; set; }
    public string Role { get; set; } = "member";
    public DateTime CreatedAt { get; set; }
}