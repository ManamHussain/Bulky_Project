using System.ComponentModel.DataAnnotations;

namespace Bulky_Project.Models
{
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        public int OrderDisplay { get; set; }
    }
}
