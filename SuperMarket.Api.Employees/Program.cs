using Microsoft.EntityFrameworkCore;
using SuperMarket.Service.Employees.Services;
using SuperMarket.Service.Employees.Interfaces;
using SuperMarket.Data.Employees.Data;
using SuperMarket.Data.Employees.Interfaces;
using SuperMarket.Data.Employees.Repository;
using SuperMarket.Api.Employees.Repository;
using AutoMapper;
using SuperMarket.Data.Employees.Mapping;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<EmployeeDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("SuperMarketDb")));

builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IEmployeeManagement, EmployeeManagement>();


builder.Services.AddScoped<ILoginService, LoginService>();
builder.Services.AddScoped<ILoginRepository, LoginRepository>();


builder.Services.AddScoped<IFilesServices, FilesServices>();
builder.Services.AddScoped<IFilesCRUD, FilesCRUD>();

var autoMapper = new MapperConfiguration(item => item.AddProfile(new AutoMapperProfile()));
IMapper mapper = autoMapper.CreateMapper();
builder.Services.AddSingleton(mapper);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}else{
    app.UseHsts();
}

app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
