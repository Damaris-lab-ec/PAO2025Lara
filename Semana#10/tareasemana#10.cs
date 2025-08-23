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
  // Aplicar operaciones de teoría de conjuntos
            // 1. Ciudadanos que no se han vacunado
            HashSet<string> noVacunados = new HashSet<string>(ciudadanos);
            noVacunados.ExceptWith(vacunadosPfizer);
            noVacunados.ExceptWith(vacunadosAstraZeneca);
            // 2. Ciudadanos que han recibido ambas dosis (intersección)
            HashSet<string> ambasDosis = new HashSet<string>(vacunadosPfizer);
            ambasDosis.IntersectWith(vacunadosAstraZeneca);
            // 3. Ciudadanos que solo han recibido Pfizer (diferencia)
            HashSet<string> soloPfizer = new HashSet<string>(vacunadosPfizer);
            soloPfizer.ExceptWith(vacunadosAstraZeneca);
            // 4. Ciudadanos que solo han recibido AstraZeneca (diferencia)
            HashSet<string> soloAstraZeneca = new HashSet<string>(vacunadosAstraZeneca);
            soloAstraZeneca.ExceptWith(vacunadosPfizer);
            // Mostrar resultados
            Console.WriteLine("=== INFORME DE VACUNACIÓN COVID-19 ===");
            Console.WriteLine($"Total de ciudadanos: {ciudadanos.Count}");
            Console.WriteLine($"Vacunados con Pfizer: {vacunadosPfizer.Count}");
            Console.WriteLine($"Vacunados con AstraZeneca: {vacunadosAstraZeneca.Count}");
            Console.WriteLine($"No vacunados: {noVacunados.Count}");
            Console.WriteLine($"Con ambas dosis: {ambasDosis.Count}");
            Console.WriteLine($"Solo Pfizer: {soloPfizer.Count}");
            Console.WriteLine($"Solo AstraZeneca: {soloAstraZeneca.Count}");