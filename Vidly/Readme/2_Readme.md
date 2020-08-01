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

