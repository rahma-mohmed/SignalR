# SignalR in .NET - Real-Time Application

This repository demonstrates the use of **SignalR** in a **.NET** application for real-time communication. It includes a chat application and an employee management system.

## Features
- Real-time chat functionality.
- Real-time employee management.
- SignalR Hub for server-client communication.
- Entity Framework Core for database operations.

## Technologies
- .NET 8
- SignalR
- Entity Framework Core
- SQL Server
- JavaScript
- Bootstrap

## Getting Started

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download)
- [Visual Studio](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

### Installation
1. Clone the repo:
   ```bash
   git clone https://github.com/rahma-mohmed/SignalR
   
2. Navigate to the project:
```bash
  cd your-repo-name
```

3. Restore dependencies:
```bash
dotnet restore
```

4. Update the database:
  Set the connection string in appsettings.json.

5. Run migrations:
```bash
dotnet ef database update
```

6. Run the app:
```bash
dotnet run
```

Open https://localhost:44377/ in your browser.

### Usage
- Chat: Send messages in real-time in browser and windows form application.
- Employee Management: Add employees and see updates in real-time.

## Acknowledgments
- [SignalR Documentation](https://docs.microsoft.com/en-us/aspnet/core/signalr/introduction?view=aspnetcore-6.0)
- [Entity Framework Core Documentation](https://docs.microsoft.com/en-us/ef/core/)
