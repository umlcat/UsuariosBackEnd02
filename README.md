# UsuariosBackEnd02
Usuarios Net Core Web API Example

This is a .Net Core Web API Example

Once you downloaded this whole solution, before the first time is executed, you will need to perform certain actions.

First, you will need to open the "appsettings.json" and change the value of the "SqlServer" options,
to a valid MS SQL Server instance identifier that you have in your development machine,
and save the changes.

Second, open the "Package Manager Console",
and run the next command:

Add-Migration createdatabase -o Data/Migrations

followed by:

Update-Database

Then, you can execute the "UsuariosBackend02" project, in the case of Development mode,
a browser window will be open, showing the builtin "Swagger" web interface that allows you,
to apply GET, POST, PUT, and DELETE Web API operations.

