📟 Calculator Implementation API
A simple, beginner-friendly RESTful API built with ASP.NET Core (.NET 8.0) to perform basic calculator operations such as addition, subtraction, multiplication, and division. Includes a sample weather forecast endpoint from the default template.

🚀 Features
➕ Addition

➖ Subtraction

✖️ Multiplication

➗ Division (with divide-by-zero protection)

🌦 Weather Forecast (sample endpoint)

📌 Endpoints
🔢 Calculator Operations
All endpoints accept and return JSON.

✅ GET /api/calculate
Performs addition.

Request Body:

json
Copy
Edit
{
  "Operand1": 5,
  "Operand2": 3,
  "Operator": "+"
}
Response:

json
Copy
Edit
{
  "Result": 8
}
➖ POST /subtract
Performs subtraction.

Request Body:

json
Copy
Edit
{
  "Number1": 10,
  "Number2": 4
}
Response:

json
Copy
Edit
{
  "Result": 6
}
✖️ POST /multiply
Performs multiplication.

Request Body:

json
Copy
Edit
{
  "Number1": 6,
  "Number2": 7
}
Response:

json
Copy
Edit
{
  "Result": 42
}
➗ POST /division
Performs division. Returns error if either operand is zero.

Request Body:

json
Copy
Edit
{
  "Number1": 10,
  "Number2": 5
}
Response:

json
Copy
Edit
{
  "Result": 2
}
🌤️ GET /WeatherForecast
Returns mock weather forecast data. This is a sample endpoint provided by the .NET template and can be removed.

🧪 Swagger UI
While running the app in development, navigate to:

bash
Copy
Edit
https://localhost:<port>/swagger
This opens the Swagger UI, where you can interactively test all endpoints.

⚙️ Getting Started
✅ Prerequisites
.NET 8.0 SDK

💻 Run Locally
bash
Copy
Edit
git clone https://github.com/Devnath03/Calculator-Implementation---API.git
cd Calculator-Implementation---API
dotnet run
🔧 Project Structure
bash
Copy
Edit
Calculator-Implementation-API/
│
├── Controllers/       # API controllers (Calculator, Weather)
├── Model/             # Request and response models
├── Program.cs         # App startup and DI
├── Startup.cs         # Configuration and middleware (if applicable)
🌐 CORS Support
CORS is enabled for all origins, methods, and headers to simplify development and testing across different frontends.

🧰 Tools & Technologies
ASP.NET Core — RESTful backend framework

C# — Main language

Swagger — Interactive API documentation

.NET 8.0 — Target SDK

CORS — Cross-Origin Resource Sharing

Dependency Injection — Built-in with ASP.NET Core

REST/HTTP — Communication protocol

🤝 Contributing
This project is for demo and learning purposes. Contributions, improvements, and feedback are welcome!

