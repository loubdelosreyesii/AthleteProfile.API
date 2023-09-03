using AthleteProfile.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Connection string
var connectionString = builder.Configuration.GetConnectionString("AthleteProfileDbConnectionString");
builder.Services.AddDbContext<AthleteProfileDbContext>(options =>
{
    options.UseSqlServer(connectionString);
});

//builder.Services.AddDbContext<AthleteProfileDbContext>
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
            Title= "Athlete Profile API",
            Version = "v1.0",
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
