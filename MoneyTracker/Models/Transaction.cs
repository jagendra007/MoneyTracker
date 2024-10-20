using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneyTracker.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Please select a category")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        [Range(1, long.MaxValue, ErrorMessage = "Amount should be grater than 0.")]
        public double Amount { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string? Note { get; set; }
        public DateTime TransactionDate { get; set; } = DateTime.Now;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        [NotMapped]
        public string? CategoryNameWithIcon 
        {
            get
            {
                return Category == null ? "" : $"{Category.Icon} {Category.CategoryName}";
            }
        }

        [NotMapped]
        public string? FormattedAmount
        {
            get
            {
                return ((Category == null || Category.Type == "Expense") ? "-" : "+") + Amount.ToString("C0");
            }
        }
    }
}
