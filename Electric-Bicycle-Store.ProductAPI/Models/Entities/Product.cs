using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Electric_Bicycle_Store.ProductAPI.Models.Entities
{
    public class Product
    {
        [Key]
        public int Product_Id { get; set; }        

        [Required(ErrorMessage ="This is a required field.")]
        [MaxLength(100, ErrorMessage ="Character length should not excced 100.")]
        public string Product_Name { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        [MaxLength(500, ErrorMessage = "Character length should not excced 500.")]
        public string Product_Description { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        
        [ForeignKey("Brand")]
        public int Brand_id { get; set; }
        public virtual Brand Brand { get; set; }    
       
        [ForeignKey("Category")]
        public int Category_Id { get; set; }
        public virtual Category Category { get; set; }

        [DataType(DataType.Date)]
        public DateTime Model_Year { get; set; }
       
        [Range(1,5000)]
        public double List_Price { get; set; }

        public string ImageUrl { get; set; }
    }
}
