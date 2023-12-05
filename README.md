# wtamucis3312final

Using lecture 12 to model what to do 1-7.

# Step 1: Create ASP.NET Core project
dotnet new webapp

# Step 2: Bring in EF Core Packages

```
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Design
```

# Step 3: Models folder!

## 3a: Set up many to many in context file
```
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder
        .Entity<UserNationalParks>()
        .HasKey(s => new { s.NationalParkId, s.UserDataId });
}
```

# Step 4: Configure appsettings.json
```
,
    "ConnectionStrings": {
        "FinalDbContext": "Data Source=Database.db"
    }
```

# Step 5: Dependency Injections

 ## 5a: Register database context in Program.cs
 ```
using Final.Models;
using Microsoft.EntityFrameworkCore;

~There's other code here~

builder.Services.AddDbContext<FinalDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("FinalDbContext")));
 ```
 **ConnectionString in quotes "FinalDbContext" must match the name you defined in appsettings.json in step 4**
 ## 5b: Bring it in as a parameter to needed classes

# Step 6: Migrations
```
dotnet ef migrations add InitialCreate 
dotnet ef database update
```

# Step 7: Seed Data
```
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}
```

# Step 8: Scafforlding
## 8a Add necessary packages
```
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
```
For scaffolding, you may need to install this additional dotnet package depending on the version of .NET you have
```
dotnet add package Microsoft.EntityFrameworkCore.Tools
```


## 8b Perform the scaffolding
|Option|Description|
|------|-----------|
|-m |The name of the model (not the DbContext)|
|-dc|The DbContext class to use including namespace.|
|-udl|Use the default layout.|
|-outDir|The relative output folder path to create the views.|
|--referenceScriptLibraries|Adds _ValidationScriptsPartial to Edit and Create pages|
```
dotnet aspnet-codegenerator razorpage -m NationalPark -dc Final.Models.FinalDbContext -udl -outDir Pages/NationalParks --referenceScriptLibraries --databaseProvider sqlite
```

# Step 9: Pagination and Sorting
First Sort then Page in code!
Amazon website pagination button is goals