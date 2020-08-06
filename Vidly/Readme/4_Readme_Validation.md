## Adding Validation
Model:
```
[Required]
[StringLength(255)]
public string Name { get; set; }
```
Controller:
```
if (!ModelState.IsValid)
{...}
```
View:
```
@Html.ValidationMessageFor(m => m.Customer.Name)
```

## Styling Validation Errors
Site.css:
```
.field-validation-error {
    color: red;
}

.input-validation-error {
    border: 2px solid red;
}
```