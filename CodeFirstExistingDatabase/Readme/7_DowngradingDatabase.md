## Migrations Downgrading a Database
Process:
![Picture 1](Images/TargetMigration_1.jpg)
```
PM> update-database -TargetMigration:DeleteDatePublishedColumnFromCoursesTable
```
![Picture 2](Images/TargetMigration_2.jpg)
To bring the database to the latest version:
![Picture 3](Images/TargetMigration_3.jpg)
```
PM> update-database
```
