﻿## The Markup

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

## Saving Data
Controller:
```
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();

            return RedirectToAction("Index", "Customers");
        }
```

## Edit Form
Controller:
```
        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();
            var viewModel = new CustomerFormViewModel()
            {
                Customer = customer,
                MembershipTypes = _context.MembershipTypes.ToList()
            };
            return View("CustomerForm", viewModel);
        }
```

Date Formar in a view:
```
	@Html.TextBoxFor(m => m.Customer.Birthdate, "{0:dd.MM.yyyy}", new { @class = "form-control" })
```

## Updating Data

Hidden field (because we don't have id on our form):
```
@Html.HiddenFor(m => m.Customer.Id);
```
Controller:
```
        [HttpPost]
        public ActionResult Save(Customer customer)
        {
            if (customer.Id == 0)
            {
                _context.Customers.Add(customer);
            }
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);
                customerInDb.Name = customer.Name;
                customerInDb.Birthdate = customer.Birthdate;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Customers");
        }
```