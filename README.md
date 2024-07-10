1. Install .NET EF Tools (if not already installed)
dotnet tool install --global dotnet-ef

2. Restore NuGet Packages
dotnet restore

3. Configure the Database
Update the appsettings.json file with your SQL Server connection string:

json
Copy code
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=DESKTOP-GJN48OV;Database=RingoMediaBackEndDeveloperTestDB;Integrated Security=True;Persist Security Info=False;"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}

4. Create and Apply Migrations
Remove existing migrations (if any)
dotnet ef migrations remove

Add a new migration
dotnet ef migrations add InitialCreate

Update the database
dotnet ef database update

Running the Application
dotnet run
