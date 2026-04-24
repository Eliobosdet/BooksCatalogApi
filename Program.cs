using BooksCatalogApi.Data;
using BooksCatalogApi.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// allowing frontend to communicate with backend
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontendApp", policy =>
    {
        policy.WithOrigins("http://localhost:4200")
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});

// picking "DefaultConnection" from configuration file: appsettings.json
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllers();
builder.Services.AddScoped<IBookService, BookService>();

var app = builder.Build();
app.UseCors("AllowFrontendApp");
app.UseAuthorization();
app.MapControllers();
app.Run();
