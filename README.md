# README

*📚 Catálogo de Cursos Digitales – Equipo 5*

~ Proyecto Académico | Ingeniería en Sistemas ~

---------------------------------------------------------------------------------------------------------------------------

**📔1. Descripción General del Proyecto**

Este proyecto académico simula el desarrollo de una mini-aplicación de consola en **C#** (`.NET Console Application`) 
que funciona como un catálogo interactivo de cursos. Su objetivo principal fue implementar y demostrar un flujo de trabajo 
colaborativo riguroso, utilizando herramientas de gestión de tareas (**Trello**) y control de versiones distribuido 
(**Git/GitHub**), como parte de un caso práctico integral.

El desarrollo se enfocó en la simulación de una arquitectura simple, pero funcional, que permite la visualización y búsqueda 
eficiente de contenido.

---------------------------------------------------------------------------------------------------------------------------

**🎯 2. Funcionalidades de la Aplicación**

La aplicación **Catálogo de Cursos** organiza el contenido en distintas áreas temáticas (Inglés, Programación, Economía, Marketing) 
y ofrece un menú interactivo con las siguientes capacidades:

- |....**Funcionalidad**...|..........................................**Descripción**....................................................|
- |........................|.............................................................................................................|
- |.Visualización Completa.|.Muestra la lista exhaustiva de todos los cursos disponibles en el catálogo..................................|
- |.Búsqueda Dinámica......|.Permite filtrar cursos por palabra clave, buscando coincidencias en el nombre o el área de especialización..|
- |.....Detalle por ID.....|.Accede y muestra la información detallada de un curso específico utilizando su identificador único (ID).....|



*🧠 Estructura de Datos (Ejemplo)*

La aplicación gestiona una colección de datos con la siguiente estructura base:

text
1. Inglés Básico A1 – Área: Inglés
2. Fundamentos de Programación – Área: Programación
3. Principios de Economía – Área: Economía
4. Introducción al Marketing Digital – Área: Marketing

---------------------------------------------------------------------------------------------------------------------------
 
**⚙️ 3. Stack Tecnológico y Herramientas**

|...**Categoría**...|.**Tecnología/Herramienta**.|...........................................**Uso Específico**................................................|
|.....Lenguaje......|.............C#.............|  Lógica de negocio e interfaz de consola.                                                                   |
|....Plataforma.....|            .NET	           |  Framework de la aplicación de consola.                                                                     |
|........IDE........|   Visual Studio / VS Code  | Entorno de desarrollo integrado.                                                                            |
|......Versiones....| 	      Git & GitHub	       | Control de versiones,   branching (ramas) y gestión de Pull Requests.                                       |
|.....Gestión.......| 	          Trello	         | Planificación, seguimiento de tareas (Backlog, In Progress, Done) y gestión de tiempos (Calendar Power-Up). |
 
---------------------------------------------------------------------------------------------------------------------------

**💻 4. Guía de Ejecución**

Para iniciar la aplicación, siga las instrucciones según su entorno de desarrollo:
__________________________________________________________________________________
**4.1. Estructura del Repositorio** 

- CataloApp/
- │
- ├── Program.cs           → Lógica principal y manejo de la aplicación.
- └── README.md            → Documento de referencia del proyecto.
__________________________________________________________________________________

** 4.2. EjecucIón desde Terminal (VS Code ) **
Asegúrese de tener el SDK de .NET instalado.

- Navegar al directorio raís del proyecto
cd CatalogoApp

- Compilar y ejecutar el programa
dotnet run

*- 🔹 Opción 1 — En terminal (VS Code / CMD)*
bash
dotnet new console -n CatalogoCursos
cd CatalogoCursos
# Reemplazar Program.cs con el código del repositorio
dotnet run
__________________________________________________________________________________

** 4.3. Ejecución en Visual Studio ** 

1. Crear un nuevo proyecto de Aplicación de Consola (.NET).
2. Reemplazar el contenido del archivo Program.cs con el código fuente del repositorio.
3. Presionar Ctrl + F5 para ejecutar la aplicación sin depuración.

*-  🔹 Opción 1 — En Visual Studio*
1. Crear un nuevo proyecto de consola (.NET).
2. Copiar el contenido del archivo `Program.cs`.
3. Presionar **Ctrl + F5** para ejecutar.

__________________________________________________________________________________

**💻 Ejemplo de uso**

***//////  CATÁLOGO COMPLETO DE RECURSOS  ///////***

Hay 5 cursos registrados
--------------------------------------------------
1. Ver Listado Completo (con Paginación)
2. Buscar Cursos (por Título, Descripción o Responsable)
3. Salir del Programa
--------------------------------------------------
Selecciona una opción (1-3):

> Si selecciona 1, se muestran los 5 cursos.
> Si selecciona 2, puede escribir los tÍtulos para filtrar.
> Si selecciona 3, sale del programa

--------------------------------------------------------------------------------------------------

**🤝 5. Metodología y Control de Versiones**
Se implementó una metodología de desarrollo colaborativo utilizando las mejores
prácticas de GitHub y Trello.

*5.1. Control de Tareas (Trello)*
- Flujo del Tablero: Backlog → In Progress → Ready → Review/QA → Done.
- Gestión del Tiempo: Uso del Calendar Power-Up para la asignación de fechas límite
y la programación de entregas.

*5.2. Control de Versiones (Git/GitHub)*
- Rama Principal: main (Rama estable de producción).
- Rama de Desarrollo: feature/catalogo-App (Rama de trabajo para la implementación de
funcionalidades).
- Commits: Se utilizó la convención de Conventional Commits.
- Pull Requests (PR): El código se integró a main únicamente tras una revisión exitosa y
aprobación del PR.

-------------------------------------------------------------------------------------------------

**🤖 6. Nota sobre GitHub Copilot (Opcional)**
Algunas líneas de apoyo y estructuras básicas del código fueron generadas con asistencia 
de GitHub Copilot, las cuales fueron posteriormente revisadas y adaptadas manualmente
por el grupo para asegurar la lógica del negocio.

-------------------------------------------------------------------------------------------------

**👥 7. Integrantes del Equipo**
Equipo 5 – Ingeniería en Sistemas

- José Cristo Carvallo Herrera. 
- Chelsea Yosmara Quintanilla Blandón.
- Marian Alejandra Guillen Castilo.
- Jorge Abraham Delgado Talavera.
- Angel Augusto Lopez Chavez.

--------------------------------------------------------------------------------------------------
**🧾 Flujo de trabajo Trello y GitHub**

*> Trello:*
  - Listas: Backlog → In Progress → Ready → Review/QA → Done
  - Power-Up: Calendar activado con fechas asignadas
  - Evidencias adjuntas (capturas del tablero y app en ejecución)

*> GitHub:*
  - Rama principal: main
  - Rama de desarrollo: feature/catalogo-cursos
  - Commit principal: feat: agregar estructura y listado de cursos
  - PR revisado y mergeado a main

-------------------------------------------------------------------------------------------------
**🧾 Reporte de Estatus Final (5-6 Líneas)**

El proyecto Catálogo de Cursos ha concluido con un 100% de avance y ha cumplido todos 
los objetivos funcionales y metodológicos. Se logró una aplicación funcional en C# que permite
la visualización y búsqueda de cursos. El equipo demostró un flujo de trabajo disciplinado, 
utilizando Trello para gestionar el progreso de las tareas (todas en `Done`) y GitHub para 
aplicar control de versiones profesional (uso de ramas y PRs). El proyecto se entrega sin riesgos 
identificados, validando la integración exitosa de la gestión de proyectos, el control de 
versiones y la programación básica en C#.

------------------------------------------------------------------------------------------------
**✅ 🏁 Logros Clave**
Este proyecto no solo resultó en una aplicación funcional, sino que también demostró la 
dominación de un flujo de trabajo de desarrollo moderno y la aplicación de conceptos 
fundamentales de programación y gestión.

** 1. Logros Técnicos (C# y Aplicación) **
- Aplicación Funcional: Se logró desarrollar una mini-aplicación de consola en C# que gestiona
y presenta dinámicamente un catálogo de cursos, cumpliendo con los requerimientos de
visualización completa, búsqueda por palabra clave y detalle por ID.

- Implementación de Lógica: Se aplicaron estructuras de datos básicas de C# (como listas
o arrays) y lógica de control de flujo (bucles y condicionales) para manejar el menú
interactivo y la funcionalidad de búsqueda.

- Dominio del Entorno .NET: Se demostró la capacidad para crear, configurar y ejecutar
una aplicación de consola estándar dentro del ecosistema de Visual Studio o utilizando
la CLI de .NET.

** 2. Logros en Gestión y Colaboración (Trello y GitHub) **
- Control de Versiones Profesional: Se estableció y mantuvo un repositorio en GitHub,
utilizando ramas (main y feature) y realizando commits significativos, lo que garantiza
la trazabilidad y la integridad del código a lo largo del desarrollo.

- Flujo de Trabajo Colaborativo (GitFlow simplificado): Se aplicó el proceso de Pull Requests 
(PR) y merges, simulando un entorno de revisión de código esencial para el desarrollo en equipo.

- Planificación Efectiva (Trello): Se utilizó Trello para desglosar el proyecto en tareas 
manejables, asignando estados (Backlog, In Progress, Done) y fechas límite (Calendar Power-Up). 
Esto aseguró la organización y la entrega del proyecto a tiempo.

** 3. Lecciones Metodológicas **
- Integración de Herramientas: El logro más significativo fue la integración exitosa de las
tres herramientas principales (C# para la codificación, Trello para el tracking y GitHub para
la colaboración), demostrando un conocimiento completo del ciclo de vida del software.

- Disciplina y Organización: Se cumplió el objetivo de aprender haciendo, reforzando la
importancia de la documentación (README) y la organización del trabajo en el contexto de 
un proyecto académico real.

En resumen, el proyecto fue un éxito al validar la capacidad del equipo para pasar 
de la planificación (Trello) a la implementación (C#) y al despliegue/control (GitHub), 
cumpliendo todos los requisitos funcionales.

------------------------------------------------------------------------------------------------
**✅ 8. Conclusión y Reporte de Cierre**
El proyecto ha sido completado al 100%, cumpliendo con todos los requerimientos 
funcionales y metodológicos establecidos.

*📊 Reporte de Estatus*
- Avance General: 100% (Todas las tarjetas de Trello en el estado Done).
- Riesgos Identificados: Ninguno al cierre del proyecto.

*💡 Lecciones Aprendidas Clave*
- La planificación detallada de tareas con Trello es crucial para la organización y
la gestión eficaz del tiempo en proyectos colaborativos.
- Git y GitHub son herramientas fundamentales para asegurar la integridad del código,
facilitar la revisión entre pares y mantener un historial de versiones claro.
- El uso de C# resultó ideal para aplicar y reforzar conceptos básicos de lógica de
programación y estructuras de datos.

-------------------------------------------------------------------------------------------------












