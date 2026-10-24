# 🚗 Rentigo
### Car Rental Management System

<p align="center">
  <img src="https://img.shields.io/badge/ASP.NET%20Core-MVC-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt="ASP.NET Core MVC" />
  <img src="https://img.shields.io/badge/C%23-Development-239120?style=for-the-badge&logo=csharp&logoColor=white" alt="C#" />
  <img src="https://img.shields.io/badge/Entity%20Framework-Core-68217A?style=for-the-badge" alt="Entity Framework Core" />
  <img src="https://img.shields.io/badge/Database-SQL%20Server-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white" alt="SQL Server" />
</p>

<p align="center">
  A web application developed to simplify vehicle rental management through a dynamic interface and database integration.
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

**Rentigo** is an ASP.NET Core MVC web application developed as part of an academic Web Development project. It allows users to explore a vehicle fleet, view rental prices and availability, and manage vehicles and their categories through a database-driven application.

## ✨ Features

- 🏠 **Dynamic Homepage** — Displays vehicles retrieved from the database.
- 🚘 **Vehicle Management** — Organizes vehicle information, including brand, model, registration number, and year.
- 📂 **Category Management** — Groups vehicles into categories.
- 💰 **Rental Pricing** — Displays daily rental prices in Tunisian dinars (DT).
- ✅ **Availability Tracking** — Shows whether a vehicle is available for rental.
- 🗄️ **Database Integration** — Uses Entity Framework Core to interact with SQL Server.
- 📱 **Responsive Interface** — Uses Bootstrap and custom CSS for a clean user experience.

## 🛠️ Technologies Used

| Technology | Purpose |
|:--|:--|
| C# | Application programming |
| ASP.NET Core MVC | Web application architecture |
| Entity Framework Core | Database access and migrations |
| SQL Server LocalDB | Database management |
| Razor | Dynamic HTML rendering |
| HTML5 & CSS3 | Interface structure and styling |
| Bootstrap 5 | Responsive design |
| Git & GitHub | Version control and source code hosting |

## 🚀 Getting Started

### Prerequisites

- Visual Studio with ASP.NET and web development support
- .NET 10 SDK
- SQL Server LocalDB

### Installation

**1. Clone the repository**

```bash
git clone https://github.com/i-stefo/rentigo.git
```

**2. Open the project**

Open `Rentigo.sln` or `Rentigo.csproj` in Visual Studio.

**3. Configure the database**

Check the connection string in `appsettings.json` and adjust it if necessary.

**4. Apply database migrations**

Run the following command in the project directory:

```bash
dotnet ef database update
```

**5. Run the application**

Start the project from Visual Studio using `Ctrl + F5`.

## 📁 Project Structure

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
├── Migrations/
├── wwwroot/
│   ├── css/
│   └── js/
├── Rentigo.csproj
└── README.md
```

## 🔗 GitHub Repository

<p align="center">
  <a href="https://github.com/i-stefo/rentigo">
    <img src="https://img.shields.io/badge/View%20Source%20Code-GitHub-181717?style=for-the-badge&logo=github&logoColor=white" alt="View source code on GitHub" />
  </a>
</p>

---

<p align="center">
  <strong>RENTIGO</strong><br/>
  <em>Academic Web Development Project — ENET'Com</em><br/>
  Developed by <strong>Ayoub Rfifi</strong>
</p>
