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