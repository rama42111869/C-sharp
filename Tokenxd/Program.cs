using BCryptNet = BCrypt.Net.BCrypt;
using System.Text.Json.Serialization;
using WebApi.Authorization;
using WebApi.Entities;
using WebApi.Helpers;
using WebApi.Services;

var builder = WebApplication.CreateBuilder(args);
 
{
    var services = builder.Services;
    var env = builder.Environment;

    services.AddDbContext<DataContext>();
    services.AddCors();
    services.AddControllers().AddJsonOptions(x =>
    { 
        x.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });
     
    services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));
     
    services.AddScoped<IJwtUtils, JwtUtils>();
    services.AddScoped<IUserService, UserService>();
}

var app = builder.Build();
 
{ 
    app.UseCors(x => x
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader()); 
    app.UseMiddleware<ErrorHandlerMiddleware>(); 
    app.UseMiddleware<JwtMiddleware>();

    app.MapControllers();
}
 
{
    var testUsers = new List<User>
    {
        new User { Id = 1, FirstName = "Admin", LastName = "User", Username = "admin", PasswordHash = BCryptNet.HashPassword("admin"), Role = Role.Admin },
        new User { Id = 2, FirstName = "Normal", LastName = "User", Username = "user", PasswordHash = BCryptNet.HashPassword("user"), Role = Role.User },
        new User { Id = 3, FirstName = "USER DOS", LastName = "´PRUEBA", Username = "USUARIO", PasswordHash = BCryptNet.HashPassword("USUARIO"), Role = Role.SuperAdmin }
    };

    using var scope = app.Services.CreateScope();
    var dataContext = scope.ServiceProvider.GetRequiredService<DataContext>();
    dataContext.Users.AddRange(testUsers);
    dataContext.SaveChanges();
}

app.Run("http://localhost:4000");