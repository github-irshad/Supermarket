Interfaces have to add to services at program.cs eg:
  builder.Services.AddScoped<IEmployeeManagement, EmployeeManagement>(); 
  Otherwise error will look like : System.InvalidOperationException: Unable to resolve service for type