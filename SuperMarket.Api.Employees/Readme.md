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
