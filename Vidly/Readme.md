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





