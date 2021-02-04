You can put XSD data set definitions in here, if you want to do data access that way.
Then just reference them in the store classes that talk to the database.

Alternately, you can use an ORM like Dapper which allows you to write SQL statements 
with placeholders for values you inject at runtime (this allows you to do things like
query by ID, for example). You can point the ORM to a local database (.mdf file, or SQLite)
or a real SQL Server installation (local or on a server you can access).