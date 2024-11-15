# PlayerDashboard

**PlayerDashboard** is a Blazor application that allows players to:  
- View and edit their profile.  
- Track and analyze their gaming stats.  
- Review recent game sessions across multiple game modes (Solo, Duel, Knockout).

## Requirements
- [.NET 8](https://dotnet.microsoft.com/download/dotnet/8.0): Ensure you have the latest version installed.

## Developing and running the app
The app.css has already been compiled, but if you want to make changes to the look and feel
fo the app with TailwindCSS, you will need to rebuild it.
To do it run the following command from the project folder:
```bash
npm install
npm run build
# or in watch mode
npm run watch
```

To run the project from command line execute run the following commands from the project folder:
```bash
dotnet build
dotnet run
```
Or open the solution in Visual Studio and run it from there :)

## Notes
The project uses local SQLite database in the project folder. It has already been prepopulated with data using migrations.