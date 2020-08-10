## Code-first Migrations

Package manager console:
```
PM> enable-migrations
```
Create my migration:
```
PM> add-migration InitialModel
```
Recreate my migration:
```
PM> add-migration InitialModel -force
```
Generate our database
```
PM> update-database
```

## Changing the Model

```
PM> add-migration AddIsSubscribedToCustomer
```

```
PM> update-database
```

```
PM> add-migration AddMembershipType
```

## Seeding the Database
Empty migratin:
```
PM> add-migration PopulateMemebershipTypes
```

```
public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (1, 0, 0, 0)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (2, 30, 1, 10)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (3, 90, 3, 15)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (4, 300, 12, 20)");
        }
```

```
PM> update-database
```

## Overriding Conventions

```
[Required]
[StringLength(255)]
public string Name { get; set; }
```

```
PM> add-migration ApplyAnnotationsToCustomerName
```

```
PM> update-database
```

## Querying Objects

## Eager Loading

Download Customers with MembershipType (by using **Include**):

```
var customers = _context.Customers.Include(c => c.MembershipType).ToList();
```

## Shortcut to Package Manager Console

Tools -> Options -> Keyboard: 
1. Show command containing: "packagemanagerconsole"
2. Press short keys: Alt+/, Alt+.

Clear console:
```
PM> cls
```
