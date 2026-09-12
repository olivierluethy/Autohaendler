# Autohaendler

A car dealership management web app built with ASP.NET Core MVC — create, edit and
delete cars, manufacturers and sales, backed by a Microsoft SQL Server database via
Entity Framework Core.

## Features

- **Cars** — full CRUD for vehicles (`AutoController`).
- **Manufacturers** — manage the car brands cars belong to (`HerstellerController`).
- **Sales** — record and manage car sales (`AutoverkaeufeController`).
- Data persisted with Entity Framework Core migrations against Microsoft SQL Server.
- Razor views for each entity (Index / Create / Edit / Delete).

## Tech

- C# / ASP.NET Core MVC
- Entity Framework Core (code-first migrations)
- Microsoft SQL Server
- Razor views

## Run

1. Configure the database connection string in `Autohaendler/appsettings.json`.
2. Apply the migrations and start the app:

```bash
cd Autohaendler
dotnet ef database update
dotnet run
```

Then open the URL shown in the console (typically `https://localhost:5001`).

You can also open `Autohaendler.sln` in Visual Studio and run it from there.
