# 🚗 Rentigo
### Car Rental Management System

<p align="center">
  <img src="https://img.shields.io/badge/ASP.NET%20Core-MVC%20%26%20Web%20API-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt="ASP.NET Core" />
  <img src="https://img.shields.io/badge-C%23-Development-239120?style=for-the-badge&logo=csharp&logoColor=white" alt="C#" />
  <img src="https://img.shields.io/badge/Entity%20Framework-Core-68217A?style=for-the-badge" alt="Entity Framework Core" />
  <img src="https://img.shields.io/badge/Database-SQL%20Server-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white" alt="SQL Server" />
</p>

<p align="center">
  A car rental management system combining an ASP.NET Core MVC application and a RESTful Web API, connected to a shared SQL Server database.
</p>

---

## 👨‍🎓 Student Information

| Detail | Information |
|:--|:--|
| **Student Name** | Ayoub Rfifi |
| **Class** | 3 IOT |
| **Group** | 2 |
| **Institution** | ENET'Com |
| **Project** | Web Development |

---

## 📌 Project Overview

**Rentigo** is an academic car rental management project developed using ASP.NET Core.

The solution contains two projects:

- **Rentigo** — An ASP.NET Core MVC web application providing a dynamic interface for managing and displaying rental vehicles and categories.
- **TP3-API** — An ASP.NET Core Web API providing RESTful endpoints to manage vehicles and categories.

Both projects connect to the same SQL Server database using Entity Framework Core.

## ✨ Features

### 🌐 MVC Web Application
- 🏠 Dynamic homepage displaying vehicles from the database.
- 🚘 Vehicle management.
- 📂 Vehicle category management.
- 💰 Daily rental pricing in Tunisian dinars (DT).
- ✅ Vehicle availability tracking.
- 📱 Responsive interface using Bootstrap and custom CSS.

### ⚡ RESTful Web API
- **Category Management:** Create, retrieve, update, and delete vehicle categories.
- **Vehicle Management:** Create, retrieve, update, and delete vehicles.
- **Database Integration:** Uses Entity Framework Core to communicate with SQL Server.
- **Relationship Management:** Each vehicle belongs to a category.
- **HTTP Methods:** GET, POST, PUT, and DELETE.
- **JSON Responses:** Exchanges data through JSON.

## 🛠️ Technologies Used

| Technology | Purpose |
|:--|:--|
| C# | Application programming |
| ASP.NET Core MVC | Web application architecture |
| ASP.NET Core Web API | RESTful API development |
| Entity Framework Core | Object-relational mapping and database access |
| SQL Server LocalDB | Database management |
| LINQ | Database queries |
| Razor | Dynamic HTML rendering |
| HTML5 & CSS3 | Interface development |
| Bootstrap 5 | Responsive design |
| Postman | API testing |
| Git & GitHub | Version control |

## 🔌 API Endpoints

The API uses the base URL:

```http
https://localhost:{port}/api
```

### CategoryVoiture Controller

| Method | Endpoint | Description |
|:--|:--|:--|
| GET | `/CategoryVoiture/ListCategories` | Get all categories |
| GET | `/CategoryVoiture/GetById/{id}` | Get category by ID |
| POST | `/CategoryVoiture/Add` | Add a category |
| PUT | `/CategoryVoiture/Update/{id}` | Update a category |
| DELETE | `/CategoryVoiture/Delete/{id}` | Delete a category |

### Voiture Controller

| Method | Endpoint | Description |
|:--|:--|:--|
| GET | `/Voiture/ListVoitures` | Get all vehicles |
| GET | `/Voiture/GetById/{id}` | Get vehicle by ID |
| POST | `/Voiture/Add` | Add a vehicle |
| PUT | `/Voiture/Update/{id}` | Update a vehicle |
| DELETE | `/Voiture/Delete/{id}` | Delete a vehicle |

## 🚀 Getting Started

### Prerequisites

- Visual Studio 2022 or later
- .NET 10 SDK
- SQL Server LocalDB
- Postman (for testing API endpoints)

### Installation

**1. Clone the repository**

```bash
git clone https://github.com/i-stefo/rentigo.git
```

**2. Open the solution**

Open `Rentigo.sln` in Visual Studio.

**3. Configure the database**

Configure the connection string in the `appsettings.json` files of both projects.

Example:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=LocationVoituresDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True"
  }
}
```

Both projects should use the same database connection.

**4. Restore NuGet packages**

```bash
dotnet restore
```

**5. Apply database migrations if needed**

Run the Entity Framework Core database update command for the project that owns the migrations:

```bash
dotnet ef database update
```

**6. Run the applications**

- Set `Rentigo` as the startup project to launch the MVC application.
- Set `TP3-API` as the startup project to launch the Web API.

Use `Ctrl + F5` to run without debugging.

**7. Test the API**

Run `TP3-API`, open Postman, and test the endpoints listed above using GET, POST, PUT, and DELETE.

## 📁 Project Structure

```text
Rentigo/
│
├── Rentigo/                      # ASP.NET Core MVC
│   ├── Controllers/
│   ├── Data/
│   ├── Models/
│   ├── Repositories/
│   ├── Views/
│   │   ├── Home/
│   │   ├── Voiture/
│   │   ├── CategoryVoiture/
│   │   └── Shared/
│   ├── Migrations/
│   └── wwwroot/
│
├── TP3-API/                      # ASP.NET Core Web API
│   ├── Controllers/
│   │   ├── CategoryVoitureController.cs
│   │   └── VoitureController.cs
│   ├── Data/
│   │   └── ApplicationDbContext.cs
│   ├── Model/
│   │   ├── CategoryVoiture.cs
│   │   └── Voiture.cs
│   ├── appsettings.json
│   └── Program.cs
│
└── Rentigo.sln
```

## 🧪 API Testing

The REST API was tested using **Postman**.

The following operations were tested successfully:

- Retrieving all vehicle categories.
- Retrieving a category by ID.
- Adding a new category.
- Updating an existing category.
- Deleting a category.
- Retrieving all vehicles.
- Retrieving a vehicle by ID.
- Adding a new vehicle.
- Updating an existing vehicle.
- Deleting a vehicle.

## 🔗 GitHub Repository

<p align="center">
  <a href="https://github.com/eduayoub01/rentigo">
    <img src="https://img.shields.io/badge/View%20Source%20Code-GitHub-181717?style=for-the-badge&logo=github&logoColor=white" alt="View source code on GitHub" />
  </a>
</p>

---

<p align="center">
  <strong>RENTIGO</strong><br/>
  <em>Academic Web Development Project — ENET'Com</em><br/>
  Developed by <strong>Ayoub Rfifi</strong>
</p>
