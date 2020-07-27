## My First ASP.NET MVC App

1. Setting Up the Development Environment (Extensions and Updates)
   1. Visual Studio Productivity Power Tools
   2. Web Essentials (incl. Markdown Editor)

## MVC in Action

**Ctrl + F5** - Compile and Run application

## Adding a Free Bootstrap Theme

1. https://bootswatch.com/, https://bootswatch.com/3/ 
2. Content/bootstrap-lumen.css
3. App_Start/BundleConfig:
```
bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap-lumen.css",
                      "~/Content/site.css"));
```

## Action Results

1) ```return View(movie);```  
2) ```return Content("Hello World");```  
3) ```return HttpNotFound();```  
4) ```return new EmptyResult();```  
5) 
```
   return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name"});
```  
**Ctrl + Shift + B** - build application without opening a new tab browser  
**Ctrl + Tab** - Switch tab  

## Action Parameters
```
public ActionResult Edit(int id) {...}
```
source:  
http://localhost:58923/movies/Edit/1  
http://localhost:58923/movies/Edit?id=1  
2) optional parameters
``` 
public ActionResult Index(int? pageIndex, string sortBy) {...} 
```
sources:  
http://localhost:58923/movies  
http://localhost:58923/movies?pageIndex=1  
http://localhost:58923/movies?pageIndex=1&sortBy=Name  
http://localhost:58923/movies?sortBy=Name  

## Custome Route

1. Before Default MapRoute
```
routes.MapRoute(
                "MoviesByReleaseDate",
                "movies/released/{year}/{month}",
                new { controller = "Movies", action = "ByReleaseDate" }
                );
```
2. Action:
```
public ActionResult ByReleaseDate(int year, int month)
```
source:  http://localhost:58923/movies/released/2014/4  
3.
```
routes.MapRoute(
                "MoviesByReleaseDate",
                "movies/released/{year}/{month}",
                new { controller = "Movies", action = "ByReleaseDate" },
                new { year = @"\d{4}", month = @"\d{2}" }
                );
```
source:  http://localhost:58923/movies/released/2014/04  

## Attribute Routing

1. RouteConfig.cs:
```
routes.MapMvcAttributeRoutes();
```
2.
```
[Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
public ActionResult ByReleaseDate(int year, int month) {...}
```

## Passing Data to Views
1) ```ViewData["RandomMovie"] = movie;```  
```<h2>@(((Movie)ViewData["RandomMovie"]).Name)</h2>```
2) ```ViewBag.RandomMovie = movie;```  
```<h2>@ViewBag.RandomMovie</h2>```
3) Where is model in the view (```return View(movie)```)?  
```
    var viewResult = new ViewResult();
    viewResult.ViewData.Model
```  

## View Models
1.
```
public class RandomMovieViewModel
{
    public Movie Movie { get; set; }
    public List<Customer> Customers { get; set; }
}
```
2.
```
var viewModel = new RandomMovieViewModel
{
    Movie = movie,
    Customers = customers
};
```
3.
```
return View(viewModel)
```
4.
```
<h2>@Model.Movie.Name</h2>
```  

## Razor Syntax
Work with css classes in a razor page:  
1.
```
@{ 
    var className = Model.Customers.Count > 2 ? "popular" : null;
}
```  
2.
```
<h2 class="@className">@Model.Movie.Name</h2>
```