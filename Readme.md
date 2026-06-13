# Task Management API (Clean Architecture - .NET 8)

A backend Task Management REST API built with **.NET 8**, following **Clean Architecture**, **CQRS (MediatR)**, and modern backend best practices.

The project demonstrates scalable architecture patterns used in real-world enterprise systems.

---

## 🚀 Features

- Create, retrieve, and manage tasks
- CQRS pattern using MediatR
- Clean Architecture separation (Domain / Application / Infrastructure / API)
- Repository pattern abstraction
- FluentValidation for request validation
- Global exception handling middleware
- Structured logging with Serilog
- Swagger/OpenAPI documentation
- Docker support
- In-memory database (EF Core) for simplicity

---

## 📦 Tech Stack
- .NET 8
- ASP.NET Core Web API
- MediatR (CQRS)
- Entity Framework Core (InMemory)
- FluentValidation
- Serilog
- Swashbuckle (Swagger)
- Docker

---

## 🐳 Running with Docker
Build image
```
docker build -t task-api -f TaskManagement.Api/Dockerfile .
```
Run container
```
docker run -p 8080:8080 task-api
```
API will be available at:
```
http://localhost:8080/swagger
```
---

## 🧪 Running Locally
```
dotnet restore
dotnet build
dotnet run --project TaskManagement.Api
```
Then open:
```
https://localhost:7120/swagger
```
