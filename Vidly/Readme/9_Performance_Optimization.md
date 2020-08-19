## Performance Optimization

### Data Tier
#### Glimpse
1.
```
PM> intall-package glimpse.mvc5
```
2.
```
PM> intall-package glimpse.ef6
```
3.
```
https://localhost:44309/glimpse.axd
```
4. Turn Glimpse On  
5. 
```
https://localhost:44309/Movies
```
6. Ajax -> Inspect -> SQL

### Output Cache
```
[OutputCache(Duration = 50)]
public ActionResult Index()
{
    return View();
}
```
Save cache to server:
```
[OutputCache(Duration = 50, Location = OutputCacheLocation.Server, VaryByParam = "genre")]
public ActionResult Index(int genre)
{
    return View();
}
```
Multiple params:
```
[OutputCache(Duration = 50, Location = OutputCacheLocation.Server, VaryByParam = "*")]
public ActionResult Index(int genre)
{
    return View();
}
```
Disable caching:
```
[OutputCache(Duration = 0, VaryByParam = "*", NoStore = true)]
public ActionResult Index()
{
    return View();
}
```