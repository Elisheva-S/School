using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using School_Server.Data;
using School_Server.Repositories;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
builder. Services.AddCors(options =>
{
	options.AddDefaultPolicy( builder =>
					  {
						  builder.AllowAnyOrigin()
									   .AllowAnyMethod()
									   .AllowAnyHeader();
					  });
});
// Add services to the container.
builder.Services.AddDbContext<SchoolDbContext>(options =>
	options.UseSqlServer(
		builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<SchoolRepository>();
builder.Services.AddControllers().AddJsonOptions(options =>
{
	options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();
app.UseCors();
app.MapControllers();

app.Run();
