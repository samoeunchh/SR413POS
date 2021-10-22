using System;
using System.ComponentModel.DataAnnotations;

namespace SR413POS.Models
{
    public class Category
    {
        [Key]
        public Guid CategoryId { get; set; }
        [Required]
        [Display(Name ="Category Name")]
        [MaxLength(50)]
        public string CategoryName { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
    }
}
