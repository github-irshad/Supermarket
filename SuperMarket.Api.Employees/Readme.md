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
dotnet ef --startup-project ..\SuperMarket.Api.Employees\ migrations add myMigration01

Updation
dotnet ef database update --startup-project ..\SuperMarket.Api.Employees\


auto increment
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
