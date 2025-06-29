using System;
using System.Collections.Generic;
namespace NotasAsignaturas
{
    // Clase que representa una asignatura con su nota
    class Asignatura
    {
        public string Nombre { get; set; }
        public double Nota { get; set; }

        public Asignatura(string nombre)
        {
            Nombre = nombre;
        }
    }

    class Curso
    {
         // Lista de asignaturas
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
        // Método para pedir notas al usuario
        public void PedirNotas()
        {
            foreach (var asignatura in Asignaturas)
            {
                Console.Write($"¿Qué nota sacaste en {asignatura.Nombre}? ");
                string input = Console.ReadLine();
                while (!double.TryParse(input, out double nota) || nota < 0 || nota > 10)
                {
                    Console.Write("Introduce una nota válida entre 0 y 10: ");
                    input = Console.ReadLine();
                }
                asignatura.Nota = double.Parse(input);
            }
        }