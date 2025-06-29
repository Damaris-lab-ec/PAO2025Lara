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