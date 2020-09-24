##  Loading Related Objects

1. **Lazy loading**
```
var course = context.Courses.Single(c => c.Id == 2);
foreach(var tag in course.Tags)
{
    Console.WriteLine(tag.Name);
}
```
How lazy loading is implementing?
```
public virtual ICollection<Tag> Tags { get; set; }
```
It's implementing with virtual.  
![Picture 1](Images/CourseProxy_1.jpg)
![Picture 2](Images/CourseProxy_2.jpg)
Tags aren't loaded immediately outside the foreach block. Inside the foreach block EF is running 
another querty to get tag for this course:
![Picture 3](Images/CourseProxy_3.jpg)

- Use when loading an object graph is costly
- Use in desktop applications
- Avoid in web applications

Disable lazy loading:
- delete virtual
OR
- Configuration.LazyLoadingEnabled
``` 
public PlutoContext()
    : base("name=PlutoContext")
{
    this.Configuration.LazyLoadingEnabled = false;
}
```

#### N + 1 Problem
To get N entities and their related entities, we'll end up with N + 1 queries.
```
foreach(var course in courses)
{
    Console.WriteLine("{0} by {1}", course.Name, course.Author.Name);
}
```
For each course EF is going to run a separate query to get the author for this couse. BUT EF only runs a query
if there is no object by that ID in its case which is at that context!!!

2. **Eager Loading**  
It's the opposite of lazy loading
a) Include("Author") - Avoid it!!!!
```
var courses = context.Courses.Include("Author").ToList();
``` 

b) Include(c => c.Author)
```
var courses = context.Courses.Include(c => c.Author).ToList();
```

#### Multiplle Levels
![Picture 4](Images/Multiple_Levels_1.jpg)
![Picture 5](Images/Multiple_Levels_2.jpg)
![Picture 6](Images/Multiple_Levels_3.jpg)

(-)Too many includes:
![Picture 7](Images/ManyIncludes_1.jpg)

3. **Explicit Loading**
