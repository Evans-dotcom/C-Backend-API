using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using UserAuthenticate.models;
using System.IO;

namespace UserAuthenticate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Ensure the uploads directory exists
            var uploadsPath = Path.Combine(Directory.GetCurrentDirectory(), "uploads");
            if (!Directory.Exists(uploadsPath))
            {
                Directory.CreateDirectory(uploadsPath);
            }

        }

                {
                });

            // Enable CORS
            app.UseCors("CorsPolicy");

            app.UseRouting();

            // Enable Authentication and Authorization middleware
            app.UseAuthentication();
            app.UseAuthorization();

            // Map controllers
            app.MapControllers();

            // Ensure uploads directory exists
            Directory.CreateDirectory(Path.Combine(app.Environment.ContentRootPath, "uploads"));
        }
    }
}
