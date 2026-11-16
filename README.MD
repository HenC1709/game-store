# GameStore

Tienda web de videojuegos: API en C# (.NET 10) + web en React y TypeScript. Proyecto de aprendizaje en equipo.

## Requisitos
- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- [Node.js LTS](https://nodejs.org)
- [Git](https://git-scm.com)
- VS Code (recomendado)

## Cómo correrlo

Primera vez:

```powershell
git clone https://github.com/HenC1709/game-store.git
cd game-store
dotnet build
cd web
npm install
cd ..
```

Cada vez que trabajes (abre la API y la web en dos ventanas):

```powershell
.\dev.ps1
```

O a mano, en dos terminales:

```powershell
# Terminal 1: API
dotnet run --project src/GameStore.Api --launch-profile http

# Terminal 2: Web
cd web
npm run dev
```

- API: http://localhost:5075/api/products
- Web: http://localhost:5173

Si PowerShell bloquea `dev.ps1`, corre una vez:
`Set-ExecutionPolicy -Scope CurrentUser -ExecutionPolicy RemoteSigned`

## Estructura

| Carpeta | Contenido |
|---|---|
| `src/` | API en C# (Domain, Application, Infrastructure, Api) |
| `tests/` | Pruebas |
| `web/` | Frontend React + TypeScript (Vite) |
| `docs/` | Decisiones, guías y diagramas |

## Cómo trabajamos
1. Nadie trabaja directo en `main`.
2. Una rama por tarea: `feature/nombre`, `fix/nombre`, `docs/nombre`.
3. Commits pequeños: `tipo(scope): descripción` (ej. `feat(catalog): add filters`).
4. Pull request con revisión de un compañero y CI en verde.
5. Antes del PR: `git pull origin main` y `npm run build` dentro de `web/`.

## Estado
MVP 0 listo: lista de juegos de punta a punta (datos en memoria).