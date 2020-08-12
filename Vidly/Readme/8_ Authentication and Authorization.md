## Restricting Access
For action:
```
[Authorize]
public ActionResult Index()
{...}
```
For controller:
```
[Authorize]
public class CustomersController : Controller
```
Globally (FilterConfig):
```
filters.Add(new AuthorizeAttribute());
```
To allow anonymous:
```
[AllowAnonymous]
public class HomeController : Controller
```