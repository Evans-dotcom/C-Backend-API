using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using UserAuthenticate.models; // Ensure the correct namespace for your models

[ApiController]
[Route("api/[controller]")]
public class CustomerController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public CustomerController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet("getallcustomers")]
    public async Task<IActionResult> GetAllCustomers()
    {
        try
        {
            var customers = await _context.Customers.ToListAsync();

            // Optional: Log the customer data being retrieved
            Console.WriteLine($"Retrieving customers: {JsonConvert.SerializeObject(customers)}");

            return Ok(customers);
        }
        catch (Exception ex)
        {
            // Log the full error
            Console.WriteLine($"Error while retrieving customers: {ex}");
            return StatusCode(500, $"An error occurred while retrieving the customers: {ex.Message}");
        }
    }

    private (string otp, DateTime expiryTime) GenerateOTP()
    {
        var random = new Random();
        string otp = random.Next(0, 999999).ToString("D6");
        DateTime expiryTime = DateTime.UtcNow.AddMinutes(5);
        return (otp, expiryTime);
    }

    private string HashPassword(string password)
    {
        return BCrypt.Net.BCrypt.HashPassword(password);
    }
}
