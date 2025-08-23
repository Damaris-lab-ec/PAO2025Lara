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
    // Crear conjunto de vacunados con Pfizer (75 ciudadanos)
            HashSet<string> vacunadosPfizer = new HashSet<string>();
            Random random = new Random();
            
            for (int i = 0; i < 75; i++)
            {
                int index = random.Next(1, 501);
                string ciudadano = $"Ciudadano {index}";
                
                // Asegurar que no se repitan
                while (vacunadosPfizer.Contains(ciudadano))
                {
                    index = random.Next(1, 501);
                    ciudadano = $"Ciudadano {index}";
                }
                
                vacunadosPfizer.Add(ciudadano);
            }