using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Electric_Bicycle_Store.ProductAPI.Models.Entities
{
    public class Category
    {
        [Key]
        public int Category_Id { get; set; } 
        [Required(ErrorMessage ="This is a required field")]
        [MaxLength(200, ErrorMessage ="Character must not exceed 200.")]
        public string Category_Name { get; set; } 
        
        public virtual ICollection<Product> Products { get; set; }
    }
}
