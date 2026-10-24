# Rentigo — Car Rental Management System

Rentigo is an ASP.NET Core MVC web application developed as part of a Web Development course project. It provides a dynamic car rental homepage and vehicle fleet management backed by a database.

## Features

- Dynamic homepage displaying vehicles from the database
- Vehicle categories and category relationships
- Vehicle availability status
- Daily rental prices displayed in Tunisian dinars (DT)
- Vehicle and category management
- Responsive interface built with Bootstrap 5 and custom CSS
- Entity Framework Core database integration

## Technologies Used

- C#
- ASP.NET Core MVC (.NET 10)
- Entity Framework Core
- SQL Server LocalDB
- Bootstrap 5
- HTML, CSS, Razor
- Git and GitHub

## Project Structure

```text
Rentigo/
├── Controllers/
├── Data/
├── Models/
├── Repositories/
├── Views/
│   ├── Home/
│   ├── Voiture/
│   ├── CategoryVoiture/
│   └── Shared/
├── wwwroot/
│   ├── css/
│   └── js/
├── Migrations/
├── Rentigo.csproj
└── README.md
```

## Getting Started

### Prerequisites

- Visual Studio with ASP.NET and web development support
- .NET 10 SDK
- SQL Server LocalDB

### Run the Application

1. Clone the repository:

   ```bash
   git clone https://github.com/i-stefo/rentigo.git
   ```

2. Open `Rentigo.sln` or `Rentigo.csproj` in Visual Studio.

3. Configure the database connection string in `appsettings.json` if needed.

4. Open the Package Manager Console or a terminal in the project directory and apply the migrations:

   ```bash
   dotnet ef database update
   ```

5. Run the application with `Ctrl + F5` in Visual Studio, or use:

   ```bash
   dotnet run
   ```

## Database

The application uses Entity Framework Core migrations to manage the database schema, including vehicles and their associated categories.

## Author

**Your Name**

## License

This project was developed for educational purposes.
