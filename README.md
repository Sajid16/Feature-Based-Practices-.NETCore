## ## Feature-Based-Practices-.NETCore

- Project Name: <b>EFCoreRelationShips</b>
  - Keep database <b>connection string</b> in appsettings.json
  - relate that <b>connection string</b> in Database related class where we create <b>DBContext</b> and <b>DBSet</b>
  - if we create new table/entity then we have to register those in <b>DBContext</b> class under <b>DBSET</b>
  
  #### -> One to Many relationship
  #### -> One to One relationship
  #### -> Many to Many relationship
  
  
  - Project Name: <b>LINQ</b>
  - <b>Projection Operators</b>
	- Select
	- SelectMany
  - <b>Filter Operators</b>
	- Where
	- OfType
  - <b>Sorting Operators</b>
	- OrderBy
	- OrderByDescending
	- ThenBy
	- ThenByDescending
	- Reverse