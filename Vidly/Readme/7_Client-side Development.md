# Client-side Development

## Calling an API Using jQuery
View (button "Delete" with id table "customers"):
```
<td>
	<button data-customer-id="@customer.Id" class="btn-link js-delete">Delete</button>
</td>
```
btn-link - button like a link  
js-delete - for selector in the below script

Script:
```
@section scripts 
{
    <script>
        $(document).ready(function () {
            $("#customers .js-delete").on("click", function () {
                const button = $(this);
                if (confirm("Are you sure you want to delete this customer?")) {
                    $.ajax({
                        url: "/api/customers/" + button.attr("data-customer-id"),
                        method: "DELETE",
                        success: function () {
                            button.parents("tr").remove();
                        }
                    });
                }
            });
        });
    </script>
}
```

## Bootbox Plug-in

```
PM> install-package bootbox -version:4.3.0
```
BundleConfig:
```
bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
				"~/Scripts/bootstrap.js",
				"~/Scripts/bootbox.js"));
```
View (bootbox.confirm):
```
bootbox.confirm("Are you sure you want to delete this customer ?", function (result) {
    if (result) {
        $.ajax({
            url: "/api/customers/" + button.attr("data-customer-id"),
            method: "DELETE",
            success: function () {
                button.parents("tr").remove();
            }
        });
    }
});
```

## Optimizing jQuery Code
```
$("#customers").on("click", ".js-delete", function () {
...
}
```
