## The Markup

Form:
```
@using (Html.BeginForm("Create", "Customers"))
{ 
	...
}
```

Label + Input:
```
<div class="form-group">
	@Html.LabelFor(m => m.Name)
	@Html.TextBoxFor(m => m.Name, new { @class = "form-control" })
</div>
```

Checkbox:
```
 <div class="checkbox">
        <label>
            @Html.CheckBoxFor(m => m.IsSubscribedToNewsletter) Subscribed to Newsletter?
        </label>
</div>
```
