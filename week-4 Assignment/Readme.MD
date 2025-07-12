# Web API Concepts in ASP.NET Core - Assignments 1 to 5

This repository contains 5 assignments demonstrating Web API development using ASP.NET Core. Each assignment highlights important concepts like RESTful APIs, Swagger, Custom Filters, CRUD Operations, CORS, and JWT Authentication.

---

## Assignment 1: RESTful Web API Basics

### What is a RESTful Web API?  
A **Web API** (Application Programming Interface) allows communication between client and server over HTTP.  
A **RESTful API** follows REST (Representational State Transfer) principles:  
- **Stateless**: Each request from client contains all information to process it.  
- **Resource-Based**: Data is treated as resources (e.g., `/api/employees`).  
- **HTTP Verbs**:  
  - `GET` → Retrieve data  
  - `POST` → Create data  
  - `PUT` → Update data  
  - `DELETE` → Remove data  

### Key Files:  
- `Controllers/ValuesController.cs`: Contains action methods for each HTTP verb.  
- `Program.cs`: Configures the API.  
- `appsettings.json`: Stores configuration like connection strings.

---

## Assignment 2: Swagger & API Testing Tools

### What is Swagger?  
Swagger (OpenAPI) automatically generates **interactive API documentation**.  
- Provides a UI to test APIs.  
- Shows available routes and expected inputs/outputs.

### How Swagger Works in ASP.NET Core:  
1. Install `Swashbuckle.AspNetCore`.  
2. Add `services.AddSwaggerGen()` in `Program.cs`.  
3. Use `app.UseSwagger()` and `app.UseSwaggerUI()`.

### API Testing with Postman  
**Postman** allows sending HTTP requests (GET, POST, PUT, DELETE).  
- Set request method and URL.  
- Add Headers (e.g., `Authorization`).  
- Use Body for JSON payloads.  

---

## Assignment 3: Custom Models & Filters

### Model Binding  
ASP.NET Core binds JSON request bodies to C# objects using `[FromBody]`.  

**Example:**
```csharp
public IActionResult PostEmployee([FromBody] Employee emp)

---

## Assignment 4: CRUD Operations

### What is CRUD?  
CRUD stands for **Create, Read, Update, Delete** – the four basic operations of persistent storage.  

| Operation | HTTP Verb | Example Route         |
|-----------|-----------|------------------------|
| Create    | POST      | `/api/employees`      |
| Read      | GET       | `/api/employees`      |
| Update    | PUT       | `/api/employees/{id}` |
| Delete    | DELETE    | `/api/employees/{id}` |

### Implementation in ASP.NET Core  
- Used a **hardcoded list** of Employees to simulate a database.  
- Added API endpoints for all CRUD operations in `EmployeeController.cs`.  
- Used `[FromBody]` to accept JSON data in POST and PUT methods.  

### Validation Logic  
- If the provided `id <= 0`, return **400 BadRequest** with message `Invalid employee id`.  
- If `id` is not found in the employee list, return **400 BadRequest**.  
- On successful PUT or DELETE, return the updated employee object or confirmation message.

### Key Files:  
- `Controllers/EmployeeController.cs`: Handles all CRUD operations.  

---

## Assignment 5: CORS & JWT Authentication

### What is CORS?  
**Cross-Origin Resource Sharing (CORS)** allows your API to be accessed by web apps hosted on different domains.  
- Enabled using:  
  ```csharp
  services.AddCors(options =>
  {
      options.AddPolicy("AllowAll", builder =>
      {
          builder.AllowAnyOrigin()
                 .AllowAnyMethod()
                 .AllowAnyHeader();
      });
  });
  app.UseCors("AllowAll");
