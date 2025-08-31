using System;
using System.Collections.Generic;
using System.Linq;

class CampanaVacunacion
{
    static void Main(string[] args)
    {
        // Conjuntos para almacenar los datos
        var todosLosCiudadanos = new HashSet<string>();
        var vacunadosPfizer = new HashSet<string>();
        var vacunadosAstraZeneca = new HashSet<string>();

        // Lógica para generar los datos ficticios
        for (int i = 1; i <= 500; i++)
        {
            todosLosCiudadanos.Add($"Ciudadano_{i}");
        }

        for (int i = 1; i <= 75; i++)
        {
            vacunadosPfizer.Add($"Ciudadano_A_{i}");
        }

        // Para simular ciudadanos con ambas dosis, se solapan los conjuntos
        for (int i = 50; i <= 124; i++)
        {
            vacunadosAstraZeneca.Add($"Ciudadano_A_{i}");
        }

        // Aquí irán las operaciones de conjuntos
        
        // Aquí irán los resultados de las operaciones
    }
}// ... (código anterior)

// Operación 1: Ciudadanos que no se han vacunado
var todosLosVacunados = new HashSet<string>(vacunadosPfizer);
todosLosVacunados.UnionWith(vacunadosAstraZeneca);
var noVacunados = new HashSet<string>(todosLosCiudadanos);
noVacunados.ExceptWith(todosLosVacunados);

// Operación 2: Ciudadanos que han recibido ambas dosis
var ambasDosis = new HashSet<string>(vacunadosPfizer);
ambasDosis.IntersectWith(vacunadosAstraZeneca);

// Operación 3: Ciudadanos que solo han recibido la vacuna de Pfizer
var soloPfizer = new HashSet<string>(vacunadosPfizer);
soloPfizer.ExceptWith(vacunadosAstraZeneca);

// Operación 4: Ciudadanos que solo han recibido la vacuna de AstraZeneca
var soloAstraZeneca = new HashSet<string>(vacunadosAstraZeneca);
soloAstraZeneca.ExceptWith(vacunadosPfizer);

// ... (siguiente paso)
// ... (código anterior)

// Mostrar los resultados en la consola
Console.WriteLine($"\n--- Listado de ciudadanos ---");
Console.WriteLine($"\nCiudadanos que no se han vacunado ({noVacunados.Count}):");
// Puedes mostrar el listado o solo el conteo si es muy largo
// foreach (var ciudadano in noVacunados) { Console.WriteLine(ciudadano); }

Console.WriteLine($"\nCiudadanos que han recibido ambas dosis ({ambasDosis.Count}):");
foreach (var ciudadano in ambasDosis)
{
    Console.WriteLine(ciudadano);
}

Console.WriteLine($"\nCiudadanos que solo han recibido la vacuna de Pfizer ({soloPfizer.Count}):");
// foreach (var ciudadano in soloPfizer) { Console.WriteLine(ciudadano); }

Console.WriteLine($"\nCiudadanos que solo han recibido la vacuna de AstraZeneca ({soloAstraZeneca.Count}):");
// foreach (var ciudadano in soloAstraZeneca) { Console.WriteLine(ciudadano); }