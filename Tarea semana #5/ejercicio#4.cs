using System;
using System.Collections.Generic;
using System.Linq;

namespace RepetirAsignaturas
{
    class Asignatura
    {
        public string Nombre { get; set; }
        public double Nota { get; set; }

        public Asignatura(string nombre)
        {
            Nombre = nombre;
        }

        public bool EstaAprobada()
        {
            return Nota >= 7;
        }
    }

    class Curso
    {
        public List<Asignatura> Asignaturas { get; private set; }

        public Curso()
        {
            Asignaturas = new List<Asignatura>
            {
                new Asignatura("Matemáticas"),
                new Asignatura("Física"),
                new Asignatura("Química"),
                new Asignatura("Historia"),
                new Asignatura("Lengua")
            };
        }

        public void PedirNotas()
        {
            foreach (var asignatura in Asignaturas)
            {
                Console.Write($"¿Qué nota sacaste en {asignatura.Nombre}? ");
                string input = Console.ReadLine();
                while (!double.TryParse(input, out double nota) || nota < 0 || nota > 10)
                {
                    Console.Write("Introduce una nota válida (0 a 10): ");
                    input = Console.ReadLine();
                }
                asignatura.Nota = double.Parse(input);
            }
        }

        public void EliminarAprobadas()
        {
            Asignaturas = Asignaturas.Where(a => !a.EstaAprobada()).ToList();
        }

        public void MostrarAsignaturasPendientes()
        {
            Console.WriteLine("\nAsignaturas que debes repetir:");
            if (Asignaturas.Count == 0)
            {
                Console.WriteLine("¡Felicidades! Has aprobado todas las asignaturas.");
            }
            else
            {
                foreach (var asignatura in Asignaturas)
                {
                    Console.WriteLine($"- {asignatura.Nombre} (nota: {asignatura.Nota})");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Curso curso = new Curso();

            curso.PedirNotas();
            curso.EliminarAprobadas();
            curso.MostrarAsignaturasPendientes();

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
