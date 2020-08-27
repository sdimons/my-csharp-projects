#### Deploying the Application
Vidly -> right mouse click -> Publish...

#### Deploying the Database
Script for all migrations from SeedUsers to the last migration
```
PM> update-database -script -SourceMigration:SeedUsers
```

#### Build Configurations
1. Toolbar -> Select "Configuration Manager"
2. Active solution configuration -> Select "New"
3. Type name of the new configuration and choose "copy settings from"
4. Solution Explorer -> web.config -> right mouse click -> Add Config Transform
5. Edit new web config (for example connectionString)
6. In the Publish you can use the new file config

