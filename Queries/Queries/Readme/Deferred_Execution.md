## Deferred Execution
Queries are not executed at the time you create them:
```
var courses = context.Courses.Where(c => c.Level == 1).OrderBy(c => c.Name)
```
Query executed when:
1. Iterating over query variable
```
foreach(var c in courses)
{
    Console.WriteLine(c.Name);
}
```
2. Calling ToList, ToArray, ToDictionary
```
var courses = context.Courses.ToList().Where(c => c.IsBeginnerCourse == true);
```
3. Calling First, Last, Single, Count, Max, Min, Average
```
var max = context.Courses.Max(c => c.Price);
```