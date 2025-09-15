using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> catalogo = new List<string>()
        {
            "National Geographic","Muy Interesante","Scientific American",
            "Vogue","Time","Forbes","Nature","Sports Illustrated",
            "PC World","Rolling Stone"
        };

        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\n--- Catálogo de Revistas ---");
            Console.WriteLine("1. Buscar revista");
            Console.WriteLine("2. Mostrar catálogo");
            Console.WriteLine("3. Salir");
            Console.Write("Elige una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("Título a buscar: ");
                    string titulo = Console.ReadLine();
                    Console.WriteLine(BuscarRevista(catalogo, titulo)
                        ? "Resultado: ¡Encontrado!"
                        : "Resultado: No encontrado.");
                    break;

                case "2":
                    Console.WriteLine("\nRevistas:");
                    foreach (var r in catalogo) Console.WriteLine($"- {r}");
                    break;

                case "3":
                    continuar = false;
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }

    static bool BuscarRevista(List<string> catalogo, string titulo)
    {
        foreach (string revista in catalogo)
            if (revista.Equals(titulo, StringComparison.OrdinalIgnoreCase))
                return true;
        return false;
    }
}
