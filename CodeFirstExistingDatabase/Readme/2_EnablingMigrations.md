## Migrations Enabling Migrations

1. Enable migration (create folder Migrations):
```
PM> enable-migrations
```
2. Create first migration (init model):
- for code first:
```
PM> add-migration InitialModel
```
- for code first with existing database (whatever you have in your model now all of that exist in your database = empty migration):
```
PM> add-migration InitialModel -IgnoreChanges -Force
```
3. Update database:
```
PM> update-database
```

RULES:
Always work on small changes and small migrations!!! (enstead of making 10 changes in your model once)