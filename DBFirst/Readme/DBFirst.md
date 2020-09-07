## Building a Model using Database-First Workflow

#### A Quick Tour of EDMX Designer
**Create Model (PlutoModel):**  
1. Project DBFirst -> right mouse click -> Add -> New Item -> ADO.NET Entity Data Model  
2. Save connection settings in App.Congig as: PlutoDbContext
3. Tick Tables
4. EF Designer from Database (Tick "Pluralize or singularize..." on "Choose your Database Object and Settings" tab)

**EDMX Designer:**
- zooming (ctrl + mouse wheel)
- layout diagram (right mouse click on empty area of diagramm -> Diagram -> Layout Diagram)
- export as image (right mouse click on empty area of diagramm -> Diagram -> Export as Image)
- collapse/expand (right mouse click on empty area of diagramm -> Diagram -> Collapse All/Expand All)
- display data type (right mouse click on empty area of diagramm -> Scalar Property Format -> Display Name and Type)


#### Uncovering the EDMX
**EDMX as XML:**  
Solution Explorer -> right mouse click the edmx file -> Open With... -> XML (Text) Editor  

**Content EDMX file:**
1. EF Runtime content
- Storage Model (representation of our Database; knows everythng about our database schema)
- Conceptual Model (representation of our Entities)
- Mapping (mapping between storage model and conceptual model)
2. EF Designer content : visual representation (zooming, moving etc.)

**How to see Mapping in a visual way:**  
Right mouse click on an entity (in EDMX Designer) -> Table Mapping

**To ignore property:**  
Right mouse click on an entity (in EDMX Designer) -> Table Mapping -> Column Mappings -> Choose the column -> Value/Property to 
"Delete"

**How to see Storage Model in a visual way:**  
Right mouse click on empty area of EDMX Designer -> Model Browser (see the section PlutoModel.Store)

#### Connection Strings
App.config or Web.config:
```
<connectionStrings>
    <add name="PlutoDBContext" connectionString="metadata=res://*/PlutoModel.csdl|res://*/PlutoModel.ssdl|res://*/PlutoModel.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=.\;initial catalog=Pluto;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
</connectionStrings>
```
**metadata:**
- res://*/PlutoModel.csdl - conceptual model
- res://*/PlutoModel.ssdl - storage model
- res://*/PlutoModel.msl - mapping

**connection string:**
- data source - server
- initial catalog - database name
- integrated security - windows or sql server autorization

#### Dealing with Database Changes
We always start with a database so we make changes in the database and then we refresh our model.
1. Adding a new table (UserProfiles):
Right mouse click on empty area of EDMX Designer -> Update Model from Database -> Tick the new table (New tab) -> Finish

2. Updating a table:
- adding column (Name to UserProfiles)
- modify column (Price To FullPrice, tinyint to smallint/varchar)
- delete column (LevelString from Courses)

Right mouse click on empty area of EDMX Designer -> Update Model from Database -> Refresh tab (our model will be refresh automaticly) -> Finish

**To validate mapping:**  
Right mouse click on empty area of EDMX Designer -> Validate

<font color='red'>**Column modifying and deleting don't work correctly so you have to delete Price and LevelString manually!!!**</font>

Tinyint is compatible with smallint so you have to do nothing. But tinyint is non-compatible with varchar so you have to modify data type manually.

3. Deleting a table
Right mouse click on empty area of EDMX Designer -> Update Model from Database -> Delete tab (automaticly) -> Finish  
BUT EF doesn't delete table from model so you have to delete the table manually from EDMX designer

#### Importing Stored Procedures
Right mouse click on empty area of EDMX Designer -> Update Model from Database -> Tick Stored Procedures and Functions

To use Stored Procedures and Functions:
```
var dbContext = new PlutoDBContext();
var courses = dbContext.GetCourses();
foreach (var c in courses)
    Console.WriteLine(c.Title);
```

#### Function Imports
Model Browser -> Function Imports

When to use Complex Types?
1. Result = Table 1 + Table 2
2. Result = Part of large table

How to create new complex type?
1. Model Browser -> Function Imports -> Choose the Function -> Double left mouse click on it
2. Check Complex
3. Click Get Column Information
4. Create New Complex Type
5. Change the Complex Type Name if you need