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

## Labels
2 ways:
1. Data Annotation  (you have to recompile)
```
[Display(Name = "Date of birth")]
public DateTime? Birthdate { get; set; }
```
2. Html
```
<label for="Birthdate">Date of birth</label>
```