# DEVELOPER NOTES

This document has descriptions of all the comands used for the creation of this web api
and notes that i considerate useful to know

This web api is based on this tutorial: **[An awesome guide on how to build RESTful APIs with ASP.NET Core](https://www.freecodecamp.org/news/an-awesome-guide-on-how-to-build-restful-apis-with-asp-net-core-87b818123e28/)** By **Evandro Gomes**

Created by: **Moises D Piñate**

--------------------
## Adding and removing a package

This command adds a package to the configuration file of the project `<project_name.csproj>`
```
dotnet add package <package-name>
```

This command removes a package from the configuration file of the project `<project_name.csproj>`
```
dotnet remove package <package-name>
```
--------------------
## Executing the app

This command build the app and executes a development server instance for testing and debug the application
```
dotnet run
```
--------------------
## Restoring packages

This command updates the configuration file of the project `<project_name.csproj>` and needs to be executed after a package manipulation. Some commands execute this command internally i.e: Adding or removing package. If you download this project from a external repository (Git, cvs, mercurial), you need to execute this command to install all the packages. (For those who comes from javascript world this is similar to `npm install`)
```
dotnet restore
```
---------------------------------
## Adding EF Core for MySQL DBMS

Oracle provides the official driver connector for NET Core applications. [MySQL EF Core](https://dev.mysql.com/doc/connector-net/en/connector-net-entityframework-core.html) 

Other alternative is [Pomelo](https://github.com/PomeloFoundation/Pomelo.EntityFrameworkCore.MySql) a Third party driver developed by the Open Source community and is based on the official MySQL EF Core driver provided by Oracle.

There are a few things to know. The official driver doesn't support EF Core up to 2.2 so this is a restriction to considerate. If your will project use a EF Core version superior to 2.x you shoud go for Pomelo driver.

```
dotnet add package Pomelo.EntityFrameworkCore.MySql (Third Party connection driver)

dotnet add package MySql.Data.EntityFrameworkCore --version 8.0.19 (Official Oracle Driver)
```
`--version` flag is optional. If not indicated will install latest version

-------------------
## Creating a manifest

The manifest is a set of files which are used to configure certain aspects of the application. For instance, the default route that will be showed once the app is running. Also it's necessary to have a manifest created if you want to install CLI tools locally

To install execute the following command
```
dotnet new tool-manifest
```
------------------
## Adding Design package

This command adds the design package used by EF Core to manage migrations and make changes on the databases. This package is necessary if you want to use the EF Core CLI tool
```
dotnet add package Microsoft.EntityFrameworkCore.Design
```

-----------------------------------------------
## Ading Entity Framework Core CLI tool.

These tools are used to manipulate EF Core and manage migrations to database. Also you can configure if the installation is global
or local (depending of the project scenario)

`--version`, `--global` and `--local` flags are optional

```
dotnet tool install --global dotnet-ef (Global install)
dotnet tool install --local dotnet-ef --version 3.0.0 (Local install)
```
### Usage of EF tools

More information on [Microsoft's official documentation](https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli)

Creating a new migration
```
dotnet ef migrations add <NameOfMigration>
```

Updating database
```
dotnet ef database update
```

Generate SQL scripts
```
dotnet ef migrations script
```
------------------------
## AutoMapper

AutoMapper is a package that allow us to create map between classes. This is very useful for map entities or similar objects
excluding some specfic properties. 

To add AutoMapper and use it, execute the following commands:

```
dotnet add package AutoMapper

dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection
```