## Code First with an Existing Database

1. Project -> Add -> New Item... -> ADO.NET Entity Data Model -> Code First From Database
2. Tick all tables except _MigrationHistory
3. Tick Pluralize or singulaze...
4. Fix class names if it's necessary (Cours -> Course)

#### Process
Existing DB -> (Reverse Engeneer) -> Model -> (Change) -> (Create Migration) -> Migration -> (Run) -> Existing DB