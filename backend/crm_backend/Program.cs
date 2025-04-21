using crm_backend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// DB-Konfiguration
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Controller usw.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Füge CORS-Policy hinzu
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
    {
        policy.WithOrigins("http://localhost:4200") // Hier den Port von deinem Angular-Frontend angeben
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

// Middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Verwendet die benannte CORS-Policy
app.UseCors("AllowFrontend");

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
