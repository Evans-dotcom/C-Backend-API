using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace UserAuthenticate.dtos
{
    public class ProductDto
    {
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string ManufacturerName { get; set; }
        [Required]
        public string ManufacturerBrand { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public IFormFile ProductImage { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Features { get; set; }
        [Required]
        public string ProductDescription { get; set; }
        [Required]
        public string MetaTitle { get; set; }
        [Required]
        public string MetaKeywords { get; set; }
        [Required]
        public string MetaDescription { get; set; }
    }
}
