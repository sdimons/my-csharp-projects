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

## Data Annotations
1. [Required]
2. [StringLength(255)]
3. [Range(1,10)]
4. [Compare("OtherProperty")]
5. [Phone]
6. [EmailAddress]
7. [Url]
8. [RegularExpression("...")]

Change default message for [Required]:
```
[Required(ErrorMessage = "Please enter customer's name")]
```