## Querying Data using LINQ
#### Inner Join
If we have navigation property:
```
var query =
    from c in  context.Courses
    select new {CourseName = c.Name, AuthorName = c.Author.Name};
```
If we don't have navigation property:
```
var query = 
    from c in context.Courses
    join a in context.Authors on c.AuthorId equals a.Id
    select new {CourseName = c.Name, AuthorName = a.Name};
```

#### Group Join (~ left join sql)
```
var query = 
    from a in context.Authors
    join c in context.Courses on a.Id equals c.AuthorId into g
    select new {AuthorName = a.Name, Courses = g.Count()};
```

#### Cross Join
```
var query = 
    from a in context.Authors
    from c in context.Courses
    select new {AuthorName = a.Name, CourseName = c.Name};
```