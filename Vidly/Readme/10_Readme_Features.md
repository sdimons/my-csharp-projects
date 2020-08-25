## Building a Feature End-to-End Systematically

#### Adding Auto-completion.
```
PM> install-package Twitter.Typeahead
```
Css (View Page Source, open css link and copy content):  
https://twitter.github.io/typeahead.js/examples/

BundleConfig:
```
bundles.Add(new StyleBundle("~/Content/css").Include(
	...
	"~/Content/typeahead.css",
	...
```
