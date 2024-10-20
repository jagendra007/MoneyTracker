using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneyTracker.Models
{
    public class Category
    {
        [Key]
        public int CategoryId {  get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage ="Title is Required.")]
        public string CategoryName { get; set; }

        [Column(TypeName ="nvarchar(5)")]
        public string Icon { get; set; }

        [Column(TypeName ="nvarchar(10)")]
        public string Type { get; set; }

        [NotMapped]
        public string? CategoryWithIcon 
        {
            get
            {
                return $"{this.Icon} {this.CategoryName}";
            }
        }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
}
