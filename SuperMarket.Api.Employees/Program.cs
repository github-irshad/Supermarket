using Microsoft.EntityFrameworkCore;
using SuperMarket.Service.Employees.Services;
using SuperMarket.Service.Employees.Interfaces;
using SuperMarket.Data.Employees.Data;
using SuperMarket.Data.Employees.Interfaces;
using SuperMarket.Data.Employees.Repository;
using SuperMarket.Api.Employees.Repository;
using AutoMapper;
using SuperMarket.Data.Employees.Mapping;
using Serilog;
using SuperMarket.Api.Employees.Middleware;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddTransient<SuperMarketExceptionMiddleware>();
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

builder.Services.AddScoped<ISalaryManagement,SalaryManagement>();
builder.Services.AddScoped<ISalaryService,SalaryService>();

builder.Services.AddScoped<IMasterSalaryService,MasterSalaryService>();
builder.Services.AddScoped<IMasterSalaryManagement,MasterSalaryManagement>();


var autoMapper = new MapperConfiguration(item => item.AddProfile(new AutoMapperProfile()));
IMapper mapper = autoMapper.CreateMapper();
builder.Services.AddSingleton(mapper);

 builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
    {
        builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
    }));


//Serilog 

// builder.Host.UseSerilog((context, config) =>
// {
//   var connectionString = context.Configuration.GetConnectionString("SuperMarketDb");

//   config.WriteTo.PostgreSQL(connectionString, "SuperMarket_Logs", needAutoCreateTable: true, schemaName: "Logs").
//   MinimumLevel.Information();

//   if (context.HostingEnvironment.IsProduction() == false)
//   {
//     config.WriteTo.Console().MinimumLevel.Information();
//   }
// });




var _logger = new LoggerConfiguration().ReadFrom.Configuration(builder.Configuration).
Enrich.FromLogContext().
// WriteTo.File("C:\\Users\\muhammed.irshad\\Desktop\\.NET\\SuperMarket\\SuperMarket.Api.Employees\\Logs\\ApiLog-.log",rollingInterval:RollingInterval.Day).
CreateLogger();
builder.Logging.AddSerilog(_logger);


// var logger =  builder.Services.BuildServiceProvider().GetService<ILogger<SuperMarketExceptionMiddleware>>();
// builder.Services.AddSingleton(logger);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}
else
{
  app.UseHsts();
}


app.UseStaticFiles();

app.UseCors("corsapp");

app.UseHttpsRedirection();

app.UseMiddleware<SuperMarketExceptionMiddleware>();

app.UseAuthorization();

app.MapControllers();


app.Run();
