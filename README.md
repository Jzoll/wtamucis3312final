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
First Sort then Page in code! <br>
<mark>Amazon website pagination button is goals </mark><br>


# Step 10: Many to many
Show the users who went to the parks by modifying the details page.

# Step 11: A New Frontier
Add pages as needed for the app.

## 11a: Details page
Add logger to details page. Then modify the Details razor page to show the visitors. Then add ability to delete national parks from the list.



# FIXME! / To-Do list

<mark>**Index page has an issue use command cmd + "f" "FIXME" to find issue**</mark>
- [x] Clicking Previous, Next forgets CurrentSort
- [x] Sorting will forget the PageNum

<mark>**Edit page **</mark>
- [x] Add the missing form bits! only park name and state are here!

<mark>**Add park visited**</mark>
- [x] Need this page to add the park to the user data visit
- [ ] Nice to have: the page link on the bottom of the page to return to the userData parks list

<mark>**UserDataIDSearch page **</mark>
- [ ] make the thing
- [x] Or remove this functionality