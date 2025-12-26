# 📝 TasksApp – ASP.NET Core MVC

A simple **ASP.NET Core MVC** application for managing daily tasks.
Built with **no database**, **clean MVC architecture**, and **Docker-ready for production**.

---

## 🚀 Features

* Add tasks
* Mark tasks as completed
* Delete tasks
* In-memory storage (no DB)
* MVC pattern (Controller → Model → View)
* Custom error handling
* Production-ready Docker setup

---

## 🧱 Tech Stack

* **ASP.NET Core MVC** (.NET 8 / 9 / 10)
* Razor Views
* Docker (multi-stage build)
* No database (in-memory list)

---

## 📂 Project Structure

```
TasksApp
│
├── Controllers
│   └── HomeController.cs
│
├── Models
│   └── TaskItem.cs
│
├── Views
│   ├── Home
│   │   ├── Index.cshtml
│   │   └── Error.cshtml
│
├── Program.cs
├── Dockerfile
├── .gitignore
└── README.md
```

---

## ▶️ Run Locally (Without Docker)

### Prerequisites

* .NET SDK installed

### Steps

```bash
dotnet restore
dotnet run
```

Open in browser:

```
https://localhost:5001
```

(or the port shown in terminal)

---

## 🐳 Run with Docker

### Build Image

```bash
docker build -t tasksapp:prod .
```

### Run Container

```bash
docker run -p 8080:8080 tasksapp:prod
```

Open:

```
http://localhost:8080
```

---

## 🔐 HTTPS in Production

This application runs over **HTTP inside the container**.

**HTTPS is handled by:**

* Azure App Service
* Azure Container Apps
* Kubernetes Ingress
* NGINX / Load Balancer

This follows **industry best practices**.

---

## ⚠️ Important Notes

* Tasks are stored **in memory**
* Data resets when app restarts
* Designed for learning and demos
* Easy to extend with:

  * Database (EF Core / Dapper)
  * Authentication
  * APIs
  * Kubernetes

---

## 🧠 Learning Goals Covered

* ASP.NET Core MVC fundamentals
* Routing and controllers
* Razor views
* Error handling (404 vs exceptions)
* Docker multi-stage builds
* Production-ready container practices

---

## 🔧 Possible Enhancements

* Persist tasks using a database
* Add edit functionality
* Add authentication & authorization
* Add REST API
* Add Docker Compose
* Deploy to Azure / Kubernetes

---

## 📜 License

This project is for **learning and demonstration purposes**.

---
