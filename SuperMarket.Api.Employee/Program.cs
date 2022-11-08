using Microsoft.EntityFrameworkCore;
using SuperMarket.Api.Employee.Data;
using SuperMarket.Api.Employee.Interfaces;
using SuperMarket.Api.Employee.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<EmployeeDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("SuperMarketDb")));
builder.Services.AddScoped<IEmployeeManagement, EmployeeManagement>();

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
