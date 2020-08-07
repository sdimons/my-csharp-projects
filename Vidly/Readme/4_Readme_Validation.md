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

## Custom Validation
Model (new class Min18YearsIfAMember):
```
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;
            if (customer.MembershipTypeId == 0 || customer.MembershipTypeId == 1)
                return ValidationResult.Success;
            if (customer.Birthdate == null)
                return new ValidationResult("Birthday is required");
            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;
            return (age >= 18)
                ? ValidationResult.Success
                : new ValidationResult("Customer should be at least 18 years old to go on a membership");
        }
    }
```
Model (Customer):
```
[Min18YearsIfAMember]
public DateTime? Birthdate { get; set; }
```
View:
```
@Html.ValidationMessageFor(m => m.Customer.Birthdate)
```
