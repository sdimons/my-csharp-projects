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

## DataTables Plug-in
```
PM> install-package jquery.datatables -version:1.10.11
```
BundleConfig (js):
```
bundles.Add(new ScriptBundle("~/bundles/lib").Include(
            "~/Scripts/jquery-{version}.js",
            "~/Scripts/bootstrap.js",
            "~/Scripts/bootbox.js",
            "~/Scripts/DataTables/jquery.dataTables.js",
            "~/Scripts/DataTables/datatables.bootstrap.js"));
```
BundleConfig (css):
```
bundles.Add(new StyleBundle("~/Content/css").Include(
          "~/Content/bootstrap-lumen.css",
          "~/Content/datatables/css/datatables.bootstrap.css",
          "~/Content/site.css"));
```
View (_Layout):
```
@Scripts.Render("~/bundles/lib")
```
View (index):
```
$("#customers").DataTable();
```

## DataTables with Ajax Source
View (script):
```
            $("#customers").DataTable({
                ajax: {
                    url: "/api/customers",
                    dataSrc: ""
                },
                columns: [
                    {
                        data: "name",
                        render: function (data, type, customer) {
                            return "<a href='/cusromers/edit/" + customer.id + "'>" + customer.name + "</a>";
                        }
                    },
                    {
                        data: "name"
                    },
                    {
                        data: "id",
                        render: function (data) {
                            return "<button class='btn-link js-delete' data-customer-id=" + data + ">Delete</button>";
                        }
                    }
                ]
            });
```
View:
```
<table id="customers" class="table table-bordered table-­hover">
    <thead>
        <tr>
            <th>Customer</th>
            <th>Membership Type</th>
            <th>Delete</th>
        </tr>
    </thead>
</table>
```
Controller (CustomersController):
```
        public ActionResult Index()
        {
           return View();
        }
```

## Returning Hierarchical Data

## DataTables Removing Records

```
table.row(button.parents("tr")).remove().draw();
```

