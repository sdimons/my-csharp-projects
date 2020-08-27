#### Deploying the Application
Vidly -> right mouse click -> Publish...

#### Deploying the Database
Script for all migrations from SeedUsers to the last migration
```
PM> update-database -script -SourceMigration:SeedUsers
```