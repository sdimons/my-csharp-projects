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
```	[Display(Name = "Date of birth")]
	public DateTime? Birthdate { get; set; }
```
2. Html
```
	<label for="Birthdate">Date of birth</label>
```

## Drop-down Lists

NewCustomerViewModel:
```
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
```

Drop-down list:
```
    <div class="form-group">
        @Html.LabelFor(m => m.Customer.MembershipTypeId)
        @Html.DropDownListFor(m => m.Customer.MembershipTypeId, new SelectList(Model.MembershipTypes, "Id", "Name"), "[Select Membership Type]", new { @class = "form-control" })
    </div>
```

## Model Binding

View:
```
<button type="submit" class="btn btn-primary">Save</button>
```
Controller:
```
[HttpPost]
public ActionResult Create(NewCustomerViewModel viewModel)
{
	return View();
}
```