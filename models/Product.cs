using System.ComponentModel.DataAnnotations;

namespace UserAuthenticate.models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ManufacturerName { get; set; }
        public string ManufacturerBrand { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; }
        public string Category { get; set; }
        public string Features { get; set; }
        public string ProductDescription { get; set; }
        public string MetaTitle { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
    }
}
