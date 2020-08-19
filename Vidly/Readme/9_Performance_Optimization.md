## Performance Optimization
1. Data Tier (Glimpse)
2. Application Tier (Output Cache, Data Cache, Release Builds)
3. Client Tier


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

### Application Tier

#### Output Cache
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

#### Data Cache
CustomersController:
```
public ActionResult Index()
{
    if (MemoryCache.Default["Genres"] == null)
    {
        MemoryCache.Default["Genres"] = _context.Genres.ToList();
    }
    var genres = MemoryCache.Default["Genres"] as IEnumerable<Genre>;
    return View();
}
```

#### Async
Async improves scalability (not performance)!!!

#### Release Builds

#### Disabling Session
Session kill scalability
You shoud make your application stateless.
Web.config:
```
<system.web>
    <sessionState mode="Off"></sessionState>
    ...
</system.web>
```

## Client Tier

