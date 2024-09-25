using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using UserAuthenticate.models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json; // Make sure to include this for JSON serialization

[ApiController]
[Route("api/[controller]")]
public class DriverController : ControllerBase
{
    private readonly DriverDbContext _context;

    public DriverController(DriverDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> AddDriver([FromBody] Driver driver)
    {
        if (driver == null)
        {
            return BadRequest("Driver data is null");
        }

        try
        {
            // Validate the phone number
            if (!ValidatePhoneNumber(driver.PhoneNumber))
            {
                return BadRequest("Phone number must start with 07 or 01 and be 10 digits long.");
            }

            // Hash the user password using BCrypt
            driver.UserPassword = BCrypt.Net.BCrypt.HashPassword(driver.UserPassword);

            // Generate OTP
            (string otp, DateTime expiryTime) = GenerateOTP();
            driver.OTP = otp;
            driver.OTPExpiryTime = expiryTime;

            // Generate a new GUID if not provided
            if (driver.GUID == Guid.Empty)
            {
                driver.GUID = Guid.NewGuid();
            }

            // Set creation timestamp
            driver.CreatedOn = DateTime.UtcNow;

            // Log the driver data being added
            Console.WriteLine($"Adding driver: {JsonConvert.SerializeObject(driver)}");

            await _context.Drivers.AddAsync(driver);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetDriver), new { id = driver.DriverId }, driver);
        }
        catch (DbUpdateException ex)
        {
            // Log the full error
            Console.WriteLine($"Error while adding driver: {ex}");
            return StatusCode(500, $"An error occurred while adding the driver: {ex.InnerException?.Message ?? ex.Message}");
        }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateDriver(int id, [FromBody] Driver driver)
    {
        if (driver == null || id != driver.DriverId)
        {
            return BadRequest("Driver data is null or ID mismatch.");
        }

        try
        {
            var existingDriver = await _context.Drivers.FindAsync(id);
            if (existingDriver == null)
            {
                return NotFound();
            }

            // Validate the phone number
            if (!ValidatePhoneNumber(driver.PhoneNumber))
            {
                return BadRequest("Phone number must start with 07 or 01 and be 10 digits long.");
            }

            // Update necessary fields
            existingDriver.DriverName = driver.DriverName;
            existingDriver.PhoneNumber = driver.PhoneNumber;
            // Update other fields as necessary

            await _context.SaveChangesAsync();
            return NoContent(); // 204 No Content
        }
        catch (DbUpdateException ex)
        {
            // Log the full error
            Console.WriteLine($"Error while updating driver: {ex}");
            return StatusCode(500, $"An error occurred while updating the driver: {ex.InnerException?.Message ?? ex.Message}");
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteDriver(int id)
    {
        try
        {
            var driver = await _context.Drivers.FindAsync(id);
            if (driver == null)
            {
                return NotFound();
            }

            _context.Drivers.Remove(driver);
            await _context.SaveChangesAsync();
            return NoContent(); // 204 No Content
        }
        catch (DbUpdateException ex)
        {
            // Log the full error
            Console.WriteLine($"Error while deleting driver: {ex}");
            return StatusCode(500, $"An error occurred while deleting the driver: {ex.InnerException?.Message ?? ex.Message}");
        }
    }

    [HttpGet]
    public async Task<IActionResult> GetAllDrivers()
    {
        try
        {
            var drivers = await _context.Drivers.ToListAsync();
            return Ok(drivers);
        }
        catch (Exception ex)
        {
            // Log the full error
            Console.WriteLine($"Error while retrieving drivers: {ex}");
            return StatusCode(500, $"An error occurred while retrieving the drivers: {ex.Message}");
        }
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetDriver(int id)
    {
        var driver = await _context.Drivers.FindAsync(id);
        if (driver == null)
        {
            return NotFound();
        }
        return Ok(driver);
    }

    // Validate phone number (must start with 07 or 01 and be 10 digits long)
    private bool ValidatePhoneNumber(string phoneNumber)
    {
        return (phoneNumber.StartsWith("07") || phoneNumber.StartsWith("01")) && phoneNumber.Length == 10;
    }

    private (string otp, DateTime expiryTime) GenerateOTP()
    {
        var random = new Random();
        string otp = random.Next(0, 999999).ToString("D6");
        DateTime expiryTime = DateTime.UtcNow.AddMinutes(5);
        return (otp, expiryTime);
    }
}
