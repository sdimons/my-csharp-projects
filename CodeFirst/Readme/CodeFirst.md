## Building a Model using Code-First Workflow

1. **Install EF:**  
Tools -> NuGet Package Manager -> Package Manager Console
```
PM> install-package EntityFramework -Version:6.1.3
```

Create **shortcuts for Package Manager Console**:  
Tools -> Options -> Keyboard -> Show commands containing: "packagemanager" -> Choose View.PackageManagerConsole -> 
Press Shortcut keys: Press Alt + / , Alt + . -> Assign -> Ok

2. **Create Model:**
```
public class Course  {...}
```

3. **Create DbContext and add DbSet in it:**
```
public class PlutoContext : DbContext
{
    public DbSet<Course> Courses { get; set; }
}
```
4. **Add connectionString to app.confug:**
```
<connectionStrings>
  <add name="DefaultConnection" connectionString="data source=.\; initial catalog=PlutoCodeFirst; integrated security=SSPI" providerName="System.Data.SqlClient"/>
</connectionStrings>
```
5. The name of connectionString to DbContext:
```
public PlutoContext() : base("name=DefaultConnection")
{
    ...
}
```
6. Enable migrations (run only once in the livetime of the project):
```
PM> enable-migrations
```
7. Add migration:
```
PM> add-migration InitialModel
```
8. Update Database:
```
PM> update-database
```