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

