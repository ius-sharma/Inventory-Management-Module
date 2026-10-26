# Practical 8 - Inventory Management Module

**AIM:** Develop Inventory Management Module using ADO.NET & CRUD Operations.

Ayush Sharma | 92400103460 | 5EC1 | Batch A | 01CE1523 - .NET Technologies

## Requirements

- Visual Studio with ASP.NET and web development tools and the .NET Framework 4.8 targeting pack.
- SQL Server Express LocalDB (instance `MSSQLLocalDB`).
- IIS Express and NuGet package restore.

## Database setup

Run `Database/Setup.sql` against `(localdb)\MSSQLLocalDB` in SQL Server Object Explorer or SQL Server Management Studio. Alternatively, from a terminal with SQL Server command-line tools:

```powershell
sqllocaldb start MSSQLLocalDB
sqlcmd -S "(localdb)\MSSQLLocalDB" -E -b -i Database/Setup.sql
```

The script creates the separate `InventoryPractical8` database and `Products` table if they do not exist; rerunning it preserves existing products. Windows authentication is used. If your SQL Server instance is different, update the `InventoryDb` connection string in `Web.config`.

## Run

1. Open `InventoryManagement.sln` in Visual Studio.
2. Restore NuGet Packages for the solution (solution-level `packages` folder).
3. Build and run using IIS Express.
4. Open `http://localhost:5088/`.

This is ASP.NET MVC 5 on .NET Framework 4.8, consistent with the preceding practical. Use Visual Studio/MSBuild and IIS Express rather than `dotnet run`.

## Features

- Add products with name, category, quantity and price in INR.
- View stock in a product table.
- Edit product details and confirm deletion before removing a product.
- Validate required fields, non-negative stock and positive price.
- Persist inventory in SQL Server using ADO.NET `SqlConnection`, parameterized `SqlCommand`, `SqlDataReader` and `ExecuteNonQuery`.
- Use typed SQL parameters, disposable connections and anti-forgery validation on modifying actions.

The submission PDF and screenshots from the running application are in `docs/`.
