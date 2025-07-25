# Product Management System - CRUD Operations

Write a C# (Asp.Net/MVC) program to input product details and store into database (using EF). Product details like Product No, Product Name, Cost Price, Qty, Sales Price. Do not Accept Sales Price, instead calculate the Sales Price based on Cost Price * 122.50% + 10% VAT (round with two decimal value). Develop the program using few of OOPS concepts like encapsulation, inheritance, etc. If user is not logged in, he/she can view the list of Products but could not add/update/delete it.

---

This is a simple full-stack web application built using C#, ASP.NET Core MVC and Entity Framework Core. The purpose of the project was to implement the basic web app — including user authentication, CRUD operations, database migrations, and role-based access — in a clean and structured way in the .NET Framework.

---

## Description

This project is basically a **Product Management System** where anyone can browse products, but only the registered(authorized) users can add, edit, or delete products (perform CRUD operations). It supports user registration and login, and stores product data in a SQL Server (LocalDB) database.

---

## Features List:

- The Unregistered users can:
  - View product list
  - View product details

- The Registered (authorized) users can:
  - Add new products
  - Edit existing products
  - Delete products

- Database is managed using **Entity Framework Core** with code-first migrations directly done from the Visual Code's developer Command Prompt and all the migrations made are logged in the project folder structure.
- The UI here is server-rendered using **Razor Views** in the MVC architecture pattern

--- 

OOP principles shown in this app:

Encapsulation: Each model (like Product) has its own properties and logic.

Abstraction: We don’t interact with the database directly; EF Core does it for us thus it is abstracted.

Inheritance: ASP.NET Identity uses class inheritance to manage Users, Identity, Authentication, Authorization, Management.

---

## Tech Stack
Backend - ASP.NET Core MVC (.NET 6.0)        
ORM - Entity Framework Core 
Database - SQL Server      
Frontend - Razor Pages, HTML, CSS, Bootstrap
Auth & Role Identities - ASP.NET Identity 
IDE - Visual Studio 2022  

---

## The MVC Architecture

This is a standard layered architecture using **ASP.NET Core MVC pattern**, and in this pattern everything is cleanly separated:

- Models – used for database entities like Product
- Controllers – handle all HTTP requests inside HomeController, ProductsController, etc.
- Views – Razor files (.cshtml) to show UI
- Data – for DB context and EF migrations

---

## How the app works 

1. The app starts from Program.cs and loads the DB context.
2. Routing is handled by app.MapControllerRoute() and directs to the correct controller and view.
3. Unauthenticated users land on the home/product listing where they can only view the product list but cannot perform any updates.
4. If they register/login, they are redirected to their dashboard with full access of CRUD operations.
5. EF Core is used for the database to communicatee with Product CRUD and is handled via ProductController.cs.
6. Views are shown using Razor syntax (.cshtml files).
7. Auth and Identity services are in Program.cs.
8. When we create a model like Product.cs, add it to the DbContext, and run the migration commands, the EF handles creating the tables.

---

## How to build and run this project

1. Clone the repo
bash:
git clone https://github.com/praptioza/ProductManagementSystem.git
cd ProductManagementSystem

2. Open in Visual Studio 2022, open the .sln file in Visual Studio. Make sure SQL Server is running locally.

3. Apply Migrations
Open Package Manager Console in VS and then run this command to ceate all tables in the local DB.
bash
Update-Database

4. Finally run the project by pressing FF5 or "Run".
This will open the browser and run the web app on 'https://localhost:port
