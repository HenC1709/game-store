# GameStore

Tienda web de videojuegos: API en C# (.NET 10) + web en React.

## Requisitos
- .NET 10 SDK, Node.js LTS, Git
- SQL Server local (Developer o Docker)

## Cómo correrlo
dotnet build
dotnet run --project src/GameStore.Api

cd web
npm install
npm run dev

## Estructura
- src/    código de la API (Domain, Application, Infrastructure, Api)
- tests/  pruebas
- web/    frontend React + TypeScript
- docs/   decisiones y diagramas

## Reglas
Ver la guía del equipo. Nadie trabaja directo en main; todo por pull request.