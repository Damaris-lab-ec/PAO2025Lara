using System;
using System.Collections.Generic;

namespace CursoAsignaturas
{
    // Clase que representa un curso con asignaturas
    class Curso
    {
        // Propiedad: lista de asignaturas
        public List<string> Asignaturas { get; set; }

        // Constructor que inicializa las asignaturas
        public Curso()
        {
            Asignaturas = new List<string>
            {
                "Matemáticas",
                "Física",
                "Química",
                "Historia",
                "Lengua"
            };
        }

        // Método para mostrar las asignaturas por pantalla
        public void MostrarAsignaturas()
        {
            Console.WriteLine("Asignaturas del curso:");
            foreach (var asignatura in Asignaturas)
            {
                Console.WriteLine("- " + asignatura);
            }
        }
    }

    // Clase principal con Main
    class Program
    {
        static void Main(string[] args)
        {
            // Crear instancia del curso
            Curso curso = new Curso();

            // Mostrar asignaturas
            curso.MostrarAsignaturas();

            // Esperar entrada para cerrar
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
