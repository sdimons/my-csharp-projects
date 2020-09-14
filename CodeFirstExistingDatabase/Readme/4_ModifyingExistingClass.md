## Migrations Modifying an Existing Class

3 Scenarios:
1. Adding a new property
2. Modifyng an existing property
3. Deleting an existing poperty

#### Rename an existing property
To Save Data use Sql() and to define nullable use nullable:
```
public override void Up()
{
    AddColumn("dbo.Courses", "Name", c => c.String(nullable: false));
    Sql("UPDATE Courses SET Name = Title");
    DropColumn("dbo.Courses", "Title");
}
```
