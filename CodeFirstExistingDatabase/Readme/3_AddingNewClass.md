## Migrations Adding a New Class
1. Add Class (with primary key Id)
```
public class Category
{
   public int Id { get; set; } 
   public string Name { get; set; }
}
```
or
```
public class Category
{
   public int CategoryId { get; set; } 
   public string Name { get; set; }
}
```
2.Create migration 
```
PM> add-migration AddCategoriesTable
```
3. The migration is empty because there's no DbSet for Category
4. Add DbSet for Category to Context
```
public virtual DbSet<Category> Categories { get; set; }
```
5. Recreate migration
```
PM> add-migration AddCategoriesTable -Force
```
6. Add data
```
Sql("INSERT INTO Categories VALUES(1, 'Web Development')");
```
**Turn of identity:**
```
Id = c.Int(nullable: false, identity: false)
```
7. Update database
```
PM> update-database
```
8. Add Category to Course as Foreign key and create migration.

#### Naming migration
1. Model Centric (AddCategory)
2. Database Centric (AddCategoriesTable)