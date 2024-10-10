//using Microsoft.AspNetCore.Builder;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Hosting;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.IdentityModel.Tokens;
//using System.Text;
//using UserAuthenticate.models;
//using Microsoft.AspNetCore.Authentication.JwtBearer;
//using Microsoft.OpenApi.Models;
//using Microsoft.Extensions.FileProviders;
//using System.IO;

//namespace UserAuthenticate
//{
//    public class Startup
//    {
//        public Startup(IConfiguration configuration)
//        {
//            Configuration = configuration;
//        }
//        public IConfiguration Configuration { get; }
//        public void ConfigureServices(IServiceCollection services)
//        {
//            services.AddControllers();

//            // Configure Entity Framework with SQL Server
//            services.AddDbContext<APIDbContext>(options =>
//                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
//            services.AddDbContext<ProductDbContext>(options =>
//              options.UseSqlServer(Configuration.GetConnectionString("ProductConnection")));
//            services.AddDbContext<DriverDbContext>(options =>
//                options.UseSqlServer(Configuration.GetConnectionString("DriverConnection")));
//            services.AddDbContext<CustomerDbContext>(options =>
//    options.UseSqlServer(Configuration.GetConnectionString("CustomerConnection")));

//            // Configure Swagger
//            services.AddSwaggerGen(c =>
//            {
//                c.SwaggerDoc("v1", new OpenApiInfo { Title = "User Authentication API", Version = "v1" });
//            });
//            // Configure JWT authentication
//            services.AddAuthentication(options =>
//            {
//                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
//                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
//            }).AddJwtBearer(options =>
//            {
//                options.TokenValidationParameters = new TokenValidationParameters
//                {
//                    ValidateIssuer = true,
//                    ValidateAudience = true,
//                    ValidateLifetime = true,
//                    ValidateIssuerSigningKey = true,
//                    ValidIssuer = Configuration["Jwt:Issuer"],
//                    ValidAudience = Configuration["Jwt:Audience"],
//                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
//                };
//            });
//        }
//        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
//        {
//            if (env.IsDevelopment())
//            {
//                app.UseSwagger();
//                app.UseSwaggerUI(c =>
//                {
//                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "User Authentication API v1");
//                    c.RoutePrefix = "swagger"; // Swagger UI at /swagger
//                });
//                app.UseDeveloperExceptionPage();
//            }
//            else
//            {
//                app.UseExceptionHandler("/Home/Error");
//                app.UseHsts();
//            }

//            app.UseHttpsRedirection();

//            // Configure static file serving
//            app.UseStaticFiles(); // Serve files from wwwroot folder
//            app.UseStaticFiles(new StaticFileOptions
//            {
//                FileProvider = new PhysicalFileProvider(
//                    Path.Combine(env.ContentRootPath, "uploads")),
//                RequestPath = "/uploads"
//            });

//            app.UseCors(options =>
//               options.WithOrigins("http://localhost:4200")
//                      .AllowAnyMethod()
//                      .AllowAnyHeader());

//            app.UseRouting();
//            app.UseAuthentication();
//            app.UseAuthorization();

//            app.UseEndpoints(endpoints =>
//            {
//                endpoints.MapControllers();
//            });

//            // Ensure uploads directory exists
//            Directory.CreateDirectory(Path.Combine(env.ContentRootPath, "uploads"));
//        }
//    }
//}