using System.ComponentModel.DataAnnotations;

namespace Electric_Bicycle_Store.ProductAPI.Models.Entities
{
    public class Brand
    {
        [Key]
        public int Brand_Id { get; set; }

        [Required(ErrorMessage ="This is a required field.")]
        public string Brand_Name { get; set; }
    }
}
