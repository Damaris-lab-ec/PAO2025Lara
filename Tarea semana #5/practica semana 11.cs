using System;
using System.Collections.Generic;

class Traductor
{
    // Diccionario inicial (Inglés -> Español y Español -> Inglés)
    static Dictionary<string, string> diccionario = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        {"time", "tiempo"},
        {"person", "persona"},
        {"year", "año"},
        {"way", "camino"},
        {"day", "día"},
        {"thing", "cosa"},
        {"man", "hombre"},
        {"world", "mundo"},
        {"life", "vida"},
        {"hand", "mano"},
        {"part", "parte"},
        {"child", "niño"},
        {"eye", "ojo"},
        {"woman", "mujer"},
        {"place", "lugar"},
        {"work", "trabajo"},
        {"week", "semana"},
        {"case", "caso"},
        {"point", "punto"},
        {"government", "gobierno"},
        {"company", "empresa"}
    };

    static void Main()
    {
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("==================== MENÚ ====================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion)) opcion = -1;

            switch (opcion)
            {
                case 1:
                    TraducirFrase();
                    break;
                case 2:
                    AgregarPalabra();
                    break;
                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
            if (opcion != 0)
            {
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
            }
        } while (opcion != 0);
    }

    static void TraducirFrase()
    {
        Console.Write("\nIngrese la frase: ");
        string frase = Console.ReadLine();
        string[] palabras = frase.Split(' ', ',', '.', ';', ':', '!', '?');

        Console.WriteLine("\nTraducción:");
        foreach (string palabra in palabras)
        {
            if (string.IsNullOrWhiteSpace(palabra)) continue;

            string palabraLimpia = palabra.Trim().ToLower();

            if (diccionario.ContainsKey(palabraLimpia))
            {
                // Mostrar traducción en inglés si está en español, o en español si está en inglés
                Console.Write(diccionario[palabraLimpia] + " ");
            }
            else if (diccionario.ContainsValue(palabraLimpia))
            {
                // Si la palabra está como "value", obtener la clave correspondiente
                foreach (var kvp in diccionario)
                {
                    if (kvp.Value.Equals(palabraLimpia, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Write(kvp.Key + " ");
                        break;
                    }
                }
            }
            else
            {
                // Si no está en el diccionario, se deja igual
                Console.Write(palabra + " ");
            }
        }
        Console.WriteLine();
    }

    static void AgregarPalabra()
    {
        Console.Write("\nIngrese la palabra en inglés: ");
        string ingles = Console.ReadLine().Trim().ToLower();

        Console.Write("Ingrese su traducción al español: ");
        string espanol = Console.ReadLine().Trim().ToLower();

        if (!diccionario.ContainsKey(ingles))
        {
            diccionario.Add(ingles, espanol);
            Console.WriteLine("Palabra agregada correctamente.");
        }
        else
        {
            Console.WriteLine("La palabra ya existe en el diccionario.");
        }
    }
}
