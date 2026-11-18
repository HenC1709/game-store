# Contexto del proyecto: GameStore

Tienda web de videojuegos hecha en equipo, como proyecto de aprendizaje.
Quien te consulta es un principiante: explica con calma, sin asumir conocimientos.

## Stack
- Backend: C# 14, .NET 10, ASP.NET Core (carpeta `src/`)
- Frontend: React 19 + TypeScript + Vite (carpeta `web/`)
- Sistema operativo del equipo: Windows. Los comandos van en PowerShell.
- Base de datos: aún sin decidir. Por ahora los datos viven en memoria.

## Estructura
- `src/GameStore.Domain` entidades · `Application` casos de uso · `Infrastructure` datos · `Api` controladores
- `web/src/components` componentes · `pages` páginas · `services` llamadas a la API · `hooks` · `types`
- Referencia de estilo: `ProductCard.tsx` y `ProductCard.css`

## Convenciones
- Código y nombres de archivos en inglés; documentación en español.
- Componentes en PascalCase: `Navbar.tsx` (respeta las mayúsculas: el CI corre en Linux).
- Clases CSS con formato bloque__elemento: `navbar__logo`, `navbar__link--active`.
- Ramas: `feature/nombre`, `fix/nombre`, `docs/nombre`. Nunca trabajar en `main`.
- Commits: `tipo(scope): descripción`, por ejemplo `feat(components): add navbar`.
- Todo cambio entra por pull request; antes de abrirlo correr `npm run build` en `web/`.

## Cómo ayudar
- Explica el error y por qué ocurre antes de dar la solución.
- Cambia solo lo que pide la tarea; no reorganices ni agregues librerías.
- No toques archivos fuera de los listados en la tarea (issue de GitHub).
- Si algo es ambiguo, pregunta en vez de suponer.
- Nunca incluyas contraseñas, tokens ni cadenas de conexión en el código.
