// Usamos el "paquete" principal de C# que nos permite hacer cosas básicas
using System; 
// Usamos "paquetes" para trabajar con listas y hacer búsquedas
using System.Collections.Generic;
using System.Linq;

namespace CatalogoCursosApp
{
    // 1. Esto es como una "ficha" o plantilla para cada curso
    public class Curso
    {
        public int Id { get; set; } // Número único de identificación del curso

        // Las siguientes propiedades NO pueden estar vacías (null!) para evitar errores
        public string Titulo { get; set; } = null!; // Nombre del curso
        public string Descripcion { get; set; } = null!; // Explicación breve del curso
        public string Responsable { get; set; } = null!; // Quién del equipo está a cargo
        public string Estado { get; set; } = null!; // Si está "Finalizado", "En Curso", o "Pendiente"

        // Este método le dice al programa cómo debe mostrarse el curso en una lista
        public override string ToString()
        {
            return $"[ID: {Id}] {Titulo} - A Cargo: {Responsable} ({Estado})";
        }
    }

    // Clase principal donde el programa empieza a ejecutarse
    public class Program
    {
        // 2. Aquí guardamos la lista de todos los cursos
        private static List<Curso> Cursos = new List<Curso>
        {
            // Creamos 5 cursos de ejemplo
            new Curso { Id = 101, Titulo = "Introducción a .NET Core", Descripcion = "Conceptos básicos de la plataforma .NET.", Responsable = "Ana Pérez", Estado = "Finalizado" },
            new Curso { Id = 102, Titulo = "Programación Asíncrona con C#", Descripcion = "Uso de tareas concurrentes con async/await.", Responsable = "Juan López", Estado = "En Curso" },
            new Curso { Id = 103, Titulo = "Desarrollo de Pantallas con React", Descripcion = "Creación de interfaces de usuario modernas.", Responsable = "Ana Pérez", Estado = "Pendiente" },
            new Curso { Id = 104, Titulo = "Bases de Datos Avanzadas", Descripcion = "Optimización y administración de bases de datos.", Responsable = "María Gómez", Estado = "Finalizado" },
            new Curso { Id = 105, Titulo = "Patrones de Diseño de Software", Descripcion = "Estudio de las estructuras de código más comunes.", Responsable = "Juan López", Estado = "En Curso" }
        };

        // Reglas para la paginación (simulada)
        private const int CursosPorPagina = 3;
        private static int PaginaActual = 1;


        // El método principal, aquí es donde el programa comienza
        public static void Main(string[] args)
        {
            Console.Title = "Catálogo de Cursos - Seguimiento del Equipo";
            bool isRunning = true; // Variable para saber si el programa debe seguir corriendo

            while (isRunning) // Bucle principal: se repite hasta que decidamos salir
            {
                Console.Clear(); // Limpia la pantalla de la consola
                DisplayMenu(); // Muestra las opciones

                // Lee lo que el usuario escribe (puede ser nulo, por eso 'string?')
                string? input = Console.ReadLine();

                // Intentamos convertir la entrada a un número entero. Si es null, lo toma como "0" para que no falle.
                if (int.TryParse(input ?? "0", out int choice))
                {
                    switch (choice) // Revisa qué número eligió el usuario
                    {
                        case 1:
                            // Muestra todos los cursos y maneja la paginación
                            DisplayCourses(Cursos, " >>>> Catálogo Completo de Cursos <<<<");
                            break;
                        case 2:
                            // Pide un texto y busca los cursos que coincidan
                            SearchCourses();
                            break;
                        case 3:
                            // Opción para salir
                            isRunning = false;
                            Console.WriteLine("\n¡Gracias! Presiona cualquier tecla para finalizar...");
                            break;
                        default:
                            DisplayError("Opción NO válida. Por favor, selecciona 1, 2 o 3.");
                            break;
                    }
                }
                else
                {
                    DisplayError("Entrada NO válida. Por favor, introduce un número.");
                }

                if (isRunning)
                {
                    Console.WriteLine("\n/// Presiona ENTER para volver al menú ///");
                    Console.ReadLine();
                }
            }

            Console.ReadKey();
        }

        // Método para dibujar el menú
        private static void DisplayMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan; // Pone el color del texto en Cyan
            Console.WriteLine("//////////////////////////////////////////////////");
            Console.WriteLine("=   SEGUIMIENTO DE TAREAS DEL EQUIPO: CATÁLOGO   =");
            Console.WriteLine("//////////////////////////////////////////////////");
            Console.ResetColor(); // Vuelve al color de texto normal
            Console.WriteLine($"Hay {Cursos.Count} cursos registrados.");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("1. Ver Listado Completo (con Paginación)");
            Console.WriteLine("2. Buscar Cursos (por Título, Descripción o Responsable)");
            Console.WriteLine("3. Salir del Programa");
            Console.WriteLine("--------------------------------------------------");
            Console.Write("Selecciona una opción (1-3): ");
        }

        // Método para mostrar errores en rojo
        private static void DisplayError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n[ERROR] {message}");
            Console.ResetColor();
        }

        // Método para mostrar la lista de cursos con la simulación de páginas
        private static void DisplayCourses(List<Curso> sourceList, string title)
        {
            PaginaActual = 1;
            bool viewing = true;

            while (viewing)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n--- {title} (Página {PaginaActual}) ---");
                Console.ResetColor();

                // Usamos LINQ (Lenguaje de Consulta) para saltar y tomar los cursos de la página actual
                var cursosEnPagina = sourceList
                    .Skip((PaginaActual - 1) * CursosPorPagina) // Cuántos registros saltar
                    .Take(CursosPorPagina) // Cuántos registros tomar (3)
                    .ToList();

                // Si la lista está vacía, volvemos a la página 1 o salimos si no hay cursos
                if (cursosEnPagina.Count == 0 && sourceList.Count > 0)
                {
                    PaginaActual = 1;
                    cursosEnPagina = sourceList.Take(CursosPorPagina).ToList();
                }
                else if (sourceList.Count == 0)
                {
                    Console.WriteLine("No se encontraron cursos.");
                    viewing = false;
                    continue;
                }

                // Mostrar los cursos
                foreach (var curso in cursosEnPagina)
                {
                    Console.WriteLine(curso.ToString());
                    Console.WriteLine($"   Descripción: {curso.Descripcion}");
                }

                // Cálculo para saber el número total de páginas
                int totalPages = (int)Math.Ceiling((double)sourceList.Count / CursosPorPagina);
                Console.WriteLine($"\nTotal de cursos: {sourceList.Count} | Páginas: {PaginaActual} de {totalPages}");
                Console.WriteLine("********************************************");
                Console.WriteLine("N. Siguiente | P. Anterior | M. Volver al Menú");
                Console.Write("Opción: ");

                // Lee la opción de navegación. Si es nula, usa una cadena vacía ("").
                string navInput = Console.ReadLine()?.ToUpper() ?? "";

                switch (navInput)
                {
                    case "N":
                        if (PaginaActual < totalPages) PaginaActual++; // Si no es la última página, avanza
                        else Console.WriteLine(">> Estás en la última página.");
                        break;
                    case "P":
                        if (PaginaActual > 1) PaginaActual--; // Si no es la primera página, retrocede
                        else Console.WriteLine(" >> Estás en la primera página.");
                        break;
                    case "M":
                        viewing = false; // Salir del bucle de paginación
                        break;
                    default:
                        DisplayError(" >>> Opción de navegación no válida.");
                        break;
                }
                // Si el usuario escribió algo que no es N, P o M, se detiene para que pueda leer el error.
                if (viewing && navInput != "M")
                {
                    if (navInput != "N" && navInput != "P") Console.ReadLine();
                }
            }
        }

        // Método para búsqueda simple por texto
        private static void SearchCourses()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n /// BUSCADOR DE CURSOS ///");
            Console.ResetColor();
            Console.Write("Introduce el texto a buscar: ");

            // Lee el texto, lo quita espacios, lo pone en minúsculas. Si es nulo, usa una cadena vacía ("").
            string searchTerm = Console.ReadLine()?.Trim().ToLower() ?? "";

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                DisplayError(" <<<< Debes escribir algo para buscar. >>>>");
                return;
            }

            // Filtra la lista de cursos: busca si el texto está en el Título, Descripción o Responsable
            var results = Cursos
                .Where(c => c.Titulo.ToLower().Contains(searchTerm) ||
                            c.Descripcion.ToLower().Contains(searchTerm) ||
                            c.Responsable.ToLower().Contains(searchTerm))
                .ToList();

            if (results.Count > 0)
            {
                // Muestra los resultados encontrados usando la función de paginación
                DisplayCourses(results, $" - Resultados para la búsqueda: '{searchTerm}'");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n >>> No se encontró ningún curso que coincida con '{searchTerm}'.");
                Console.ResetColor();
            }
        }
    }
}
