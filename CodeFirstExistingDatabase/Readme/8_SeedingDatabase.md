## Seeding Database
To initialize our database with some dummy data

1. Empty migration + Sql method
- create migration (without model changing)
- edit Up method
```
public override void Up()
{
    Sql("INSERT INTO Categories...");
}
```
2. Seed method:
```
protected override void Seed(CodeFirstExistingDatabase.PlutoContext context)
{
     context.Authors.AddOrUpdate(a => a.Name, 
        new Author
        {
            Name = "Author 1",
            Courses = new Collection<Course>()
            {
                new Course()
                {
                    Name = "Course for Author 1",
                    Description = "DEscription"
                }
            }
        });
}
```
then make update database