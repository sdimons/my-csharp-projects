## My First ASP.NET MVC App

1. Setting Up the Development Environment (Extensions and Updates)
   1. Visual Studio Productivity Power Tools
   2. Web Essentials (incl. Markdown Editor)

## MVC in Action

Ctrl + F5 - Compile and Run application

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

Ctrl + Shift + B - build application without opening a new tab browser
Ctrl + Tab - Switch tab