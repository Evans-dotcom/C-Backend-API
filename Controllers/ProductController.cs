using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using UserAuthenticate.models;
using UserAuthenticate.dtos;

namespace UserAuthenticate.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ProductDbContext _context;
        private readonly IHostEnvironment _environment;
        private readonly IConfiguration _configuration;

        public ProductController(ProductDbContext context, IHostEnvironment environment, IConfiguration configuration)
        {
            _context = context;
            _environment = environment;
            _configuration = configuration;
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct([FromForm] ProductDto productDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var product = new Product
            {
                ProductName = productDto.ProductName,
                ManufacturerName = productDto.ManufacturerName,
                ManufacturerBrand = productDto.ManufacturerBrand,
                Price = productDto.Price,
                Category = productDto.Category,
                Features = productDto.Features,
                ProductDescription = productDto.ProductDescription,
                MetaTitle = productDto.MetaTitle,
                MetaKeywords = productDto.MetaKeywords,
                MetaDescription = productDto.MetaDescription
            };

            if (productDto.ProductImage != null)
            {
                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "uploads");
                var uniqueFileName = GetUniqueFileName(productDto.ProductImage.FileName);
                var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await productDto.ProductImage.CopyToAsync(fileStream);
                }

                product.ImagePath = "/uploads/" + uniqueFileName;
            }
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

        private string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                    + "_"
                    + Guid.NewGuid().ToString().Substring(0, 4)
                    + Path.GetExtension(fileName);
        }
    }
}