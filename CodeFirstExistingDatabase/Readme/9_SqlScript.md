## Migrations Sql Script

Run the following command to get a SQL script of all your migrations:
```
PM> Update-‐Database ­‐Script ­‐SourceMigration:0
```
You may want to change the range of migrations included in the SQL script:
```
PM> Update-­Database -Script -SourceMigration:Migr1 -TargetMigration:Migr2
```