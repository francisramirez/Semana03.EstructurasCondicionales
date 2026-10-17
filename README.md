# Semana 3 — Estructuras de Control (Día 1)

**CodeArt Academy · Curso 1: Fundamentos de Programación con C#**

Material **3.4 — Código y ejemplos — Día 1**. Solución de Visual Studio con ocho proyectos de consola independientes para practicar estructuras condicionales.

## Requisitos
- Visual Studio 2022 (con carga de trabajo **Desarrollo de escritorio con .NET**) o VS Code
- **.NET 8 SDK** instalado

## Abrir y ejecutar
1. Abre `Semana03.EstructurasCondicionales.sln` en Visual Studio 2022.
2. En el Explorador de soluciones, haz clic derecho sobre el proyecto deseado y selecciona **Establecer como proyecto de inicio**.
3. Presiona **Ctrl+F5** para ejecutar sin depuración o **F5** para depurar.
4. Para compilar toda la solución, selecciona **Compilar → Compilar solución** (`Ctrl+Mayús+B`).

También puedes usar la terminal desde la carpeta raíz:

```bash
dotnet build Semana03.EstructurasCondicionales.sln
dotnet run --project Ejemplo01_If
```

## Proyectos
| Proyecto | Tema |
|---|---|
| Ejemplo01_If | Condicional simple `if` |
| Ejemplo02_IfElse | Condicional doble `if/else` |
| Ejemplo03_ElseIf | Condicional múltiple `else if` |
| Ejemplo04_OperadoresLogicos | Operadores lógicos y validación de retiro |
| Ejemplo05_CondicionalesAnidados | Condicionales anidados |
| Ejemplo06_Switch | Menú con `switch` |
| Ejemplo07_TryParse | Validación de entradas con `TryParse` |
| Ejemplo08_ATM_Validaciones | Caso integrador ATM |

**Nota:** Los ejemplos didácticos 01–06 usan `Parse()` para simplificar el enfoque en condicionales; una entrada inválida puede lanzar una excepción. Los ejemplos 07–08 introducen `TryParse()`.

## Publicar en GitHub
En la terminal, dentro de esta carpeta:

```bash
git init
git add .
git commit -m "Agregar ejemplos de estructuras condicionales semana 3"
```

Crea un repositorio **vacío** en GitHub (sin README ni `.gitignore` inicial), copia su URL y ejecuta:

```bash
git branch -M main
git remote add origin https://github.com/TU_USUARIO/TU_REPOSITORIO.git
git push -u origin main
```

También puedes publicar desde **Git → Crear repositorio Git** en Visual Studio.

## Uso académico
Ejemplos preparados para acompañar la explicación del docente y los laboratorios de la Semana 3. Los importes con `decimal.Parse()`/`TryParse()` utilizan la configuración regional del sistema operativo.
