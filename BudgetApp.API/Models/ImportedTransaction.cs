using System.ComponentModel.DataAnnotations.Schema;

namespace BudgetApp.API.Models;

[Table("imported_transactions")]
public class ImportedTransaction
{
    public Guid Id { get; set; }
    public Guid HouseholdId { get; set; }
    public string Source { get; set; } = string.Empty;
    public string ExternalId { get; set; } = string.Empty;
    public DateOnly TransactionDate { get; set; }
    public DateOnly? OriginalDate { get; set; }
    public string? AccountType { get; set; }
    public string? AccountName { get; set; }
    public string? AccountNumber { get; set; }
    public string? InstitutionName { get; set; }
    public string MerchantName { get; set; } = string.Empty;
    public string? CustomName { get; set; }
    public decimal Amount { get; set; }
    public string? Description { get; set; }
    public string? Category { get; set; }
    public string? Note { get; set; }
    public string? IgnoredFrom { get; set; }
    public bool TaxDeductible { get; set; }
    public List<string> TransactionTags { get; set; } = new();
    public string RawData { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public string? ReviewedTransactionType { get; set; }
}