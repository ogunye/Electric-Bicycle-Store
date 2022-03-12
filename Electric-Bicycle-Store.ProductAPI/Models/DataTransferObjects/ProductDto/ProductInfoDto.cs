using System;
using System.ComponentModel.DataAnnotations;

namespace Electric_Bicycle_Store.ProductAPI.Models.DataTransferObjects.ProductDto
{
    public class ProductInfoDto
    {
       [Display(Name ="Product ID")]
        public int Product_Id { get; set; }
        
        [Display(Name = "Product Name")]
        public string Product_Name { get; set; }

        [Display(Name = "Product Description")]
        public string Product_Description { get; set; }

        [Display(Name = "Brand")]
        public int Brand_id { get; set; }


        [Display(Name = "Category")]
        public int Category_Id { get; set; }


        [Display(Name = "Model Year")]
        public DateTime Model_Year { get; set; }

        [Display(Name = "Price")]
        public double List_Price { get; set; }        
    }
}
