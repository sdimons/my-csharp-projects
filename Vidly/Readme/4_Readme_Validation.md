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