using System;
using System.Collections.Generic;
using System.Linq;
namespace VacunacionCOVID19
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear conjunto universal de 500 ciudadanos
            HashSet<string> ciudadanos = new HashSet<string>();
            for (int i = 1; i <= 500; i++)
            {
                ciudadanos.Add($"Ciudadano {i}");
            }