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