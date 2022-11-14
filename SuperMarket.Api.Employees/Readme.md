Interfaces have to add to services at program.cs eg:
  builder.Services.AddScoped<IEmployeeManagement, EmployeeManagement>(); 
  Otherwise error will look like : System.InvalidOperationException: Unable to resolve service for type



To make a project and run migration in VS Code. Migration error solved.
  cd ./project_with_migrations_folder
  dotnet ef --startup-project ../my_startup_project_path/ migrations add myMigration01