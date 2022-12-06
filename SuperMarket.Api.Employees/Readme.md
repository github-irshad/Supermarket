Interfaces have to add to services at program.cs eg:
  builder.Services.AddScoped<IEmployeeManagement, EmployeeManagement>(); 
  Otherwise error will look like : System.InvalidOperationException: Unable to resolve service for type



To make a project and run migration in VS Code. Migration error solved.
  cd ./project_with_migrations_folder
  dotnet ef --startup-project ../my_startup_project_path/ migrations add myMigration01


Script
script-migration
  dotnet ef dbcontext script
    options:> --output <FILE> (The file to write the result to.)


To this project:
Migration
dotnet ef --startup-project ..\SuperMarket.Api.Employees\ migrations add newDetails

Updation
dotnet ef database update --startup-project ..\SuperMarket.Api.Employees\


auto increment
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

Usage: dotnet ef migrations script [arguments] [options]

Arguments:
  <FROM>  The starting migration. Defaults to '0' (the initial database).
  <TO>    The ending migration. Defaults to the last migration.

Options:
  -o|--output <FILE>                     The file to write the result to.
  -i|--idempotent                        Generate a script that can be used on a
 database at any migration.
  -c|--context <DBCONTEXT>               The DbContext to use.
  -p|--project <PROJECT>                 The project to use.
  -s|--startup-project <PROJECT>         The startup project to use.
  --framework <FRAMEWORK>                The target framework.
  --configuration <CONFIGURATION>        The configuration to use.
  --runtime <RUNTIME_IDENTIFIER>         The runtime to use.
  --msbuildprojectextensionspath <PATH>  The MSBuild project extensions path. Defaults to "obj".
  --no-build                             Don't build the project. Only use this 
                                         when the build is up-to-date.

dotnet ef migrations script --startup-project ..\SuperMarket.Api.Employees\




/////////////
,
  "Serilog":{
    "using":["Serilog.Sinks.File",
    "Serilog.Sinks.PostgreSQL"],
    "Minimumlevel": {
      "Default" : "Error"
    },
    "WriteTo":[{
      "Name" : "File",
      "Args" : {
        "Path" : "C:\\Users\\muhammed.irshad\\Desktop\\.NET\\SuperMarket\\SuperMarket.Api.Employees\\Logs\\ApiLog-.log",
        "rollingInterval" : "Day"}
      },
      {
        "Name" : "PostgreSQL",
        "Args": {
          "connectionString": "Host=localhost;Database=SuperMarketDb;Username=postgres;Password=Admin@123;Schema = Logs",
          "schemaName" : "Logs",
          "tableName": "SuperMarket_Logs",
          "needAutoCreateTable": true,
          "batchPostingLimit": 1 
        }
      }     
          
        ]
      }

///////////////
If debugger is not working, delete  .vscode folder (somekind of supporting file for debigguing). open command pallette search .net generrate assests for buiilding and debug