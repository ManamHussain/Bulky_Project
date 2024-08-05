using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bulky_Project.Models
{
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(30),MinLength(3)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [Required]
        [Range(1,100,ErrorMessage ="Display Order must be between 1,100")]
        [DisplayName("Display Order")]
        public int OrderDisplay { get; set; }
    }
}
