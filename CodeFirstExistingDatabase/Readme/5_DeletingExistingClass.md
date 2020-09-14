## Migrations Deleting an Existing Class

To Save Data From deleting table:
```
CreateTable(
    "dbo._Categories",
    c => new
        {
            Id = c.Int(nullable: false, identity: true),
            Name = c.String(),
        })
    .PrimaryKey(t => t.Id);
Sql("INSERT INTO _Categories (Name) SELECT Name FROM Categories");
```