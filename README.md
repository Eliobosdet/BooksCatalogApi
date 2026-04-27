# 📚 Books Catalog - Full Stack Application

A modern, educational full-stack application demonstrating the integration between **Angular** and **.NET Core Web API**. This project implements a complete **CRUD** (Create, Read, Update, Delete) system following **RESTful** standards.

## 🚀 Tech Stack

### Frontend
- **Angular 19** (Standalone Architecture)
- **Reactive Forms** for robust data validation.
- **RxJS (Subjects/Observables)** for cross-component communication and real-time list updates.
- **TypeScript** for strong typing and data modeling.

### Backend
- **.NET 9 / .NET Core Web API**
- **Entity Framework Core** as the Object-Relational Mapper (ORM).
- **SQLite** for lightweight, portable data storage.
- **CORS Policy** configured for secure communication with the frontend.

## 📋 Key Features

- [x] **Dynamic Listing**: Fetches and displays books in real-time from the database.
- [x] **Reactive Data Entry**: A form with advanced validation rules.
- [x] **Custom Validation**: Logic to prevent future publication years (Dynamic Year Validation).
- [x] **Real-time Refresh**: The book list updates automatically upon successful form submission using the Observer Pattern.
- [x] **RESTful API**: Standardized endpoints for all CRUD operations.

## 🛠️ Architecture & Patterns

- **Clean Architecture**: Separation of concerns between UI Components, Data Services, and Models.
- **Service-Repository Pattern**: Business logic is isolated from the Controllers for better maintainability.
- **Type Safety**: Synchronized data models between C# Entities and TypeScript Interfaces.

## 🔧 Installation & Setup

### 1. Backend Setup (.NET)
```bash
# Navigate to the API folder
dotnet restore
dotnet run
```
### 2. Frontend Setup (Angular)
```bash
# Navigate to the frontend folder
npm install
ng serve
```
The application will be available at http://localhost:4200.
