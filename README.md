## Calculator Implementation API

A simple RESTful API for performing basic calculator operations, built with ASP.NET Core.

Features
Addition
Subtraction
Multiplication
Division (with zero-check protection)
Test endpoint for weather forecast (template)
Endpoints
Calculator Endpoints
All endpoints accept and return JSON.

GET /api/calculate
Performs addition.
Body:

{
  "Operand1": 5,
  "Operand2": 3,
  "Operator": "+"
}
Response:

{ "Result": 8 }
POST /subtract
Performs subtraction.

POST /multiply
Performs multiplication.

POST /division
Performs division. Returns error if either operand is zero.

Body example for POST:

{
  "Number1": 10,
  "Number2": 5
}
Response:

{ "Result": 5 }
Weather Forecast (Sample)
GET /WeatherForecast
Returns random weather data (template endpoint, can be removed).
Getting Started
Prerequisites
.NET 8.0 SDK
Run Locally
git clone https://github.com/Devnath03/Calculator-Implementation---API.git
cd Calculator-Implementation---API
dotnet run
Swagger UI
When running in development, browse to /swagger for interactive API documentation and testing.

CORS
CORS is enabled for all origins, methods, and headers for easy API testing.

Project Structure
Controllers/ — API controllers
Model/ — Data models


This is a basic calculator API for demo and learning purposes. Contributions are welcome!

## Tools & Technologies
* ASP.NET Core
For building the RESTful API backend.

* C#
Main programming language used for API logic and controllers.

* Swagger
For generating interactive API documentation (/swagger endpoint).

* .NET 8.0 SDK
Target framework for building and running the project.

* CORS
Cross-Origin Resource Sharing enabled for API accessibility.

* Dependency Injection
Used for controller and service management (standard in ASP.NET Core).

* HTTP/REST
Communication protocol for client-server interaction.
