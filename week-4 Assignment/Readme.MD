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
