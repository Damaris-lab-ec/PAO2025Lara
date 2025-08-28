using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static Dictionary<string, string> diccionario = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
    
    static void Main(string[] args)
    {
        InicializarDiccionario();
        MostrarMenu();
    }

    static void InicializarDiccionario()
    {
        // Palabras base sugeridas
        diccionario.Add("time", "tiempo");
        diccionario.Add("person", "persona");
        diccionario.Add("year", "año");
        diccionario.Add("way", "camino/forma");
        diccionario.Add("day", "día");
        diccionario.Add("thing", "cosa");
        diccionario.Add("man", "hombre");
        diccionario.Add("world", "mundo");
        diccionario.Add("life", "vida");
        diccionario.Add("hand", "mano");
        diccionario.Add("part", "parte");
        diccionario.Add("child", "niño/a");
        diccionario.Add("eye", "ojo");
        diccionario.Add("woman", "mujer");
        diccionario.Add("place", "lugar");
        diccionario.Add("work", "trabajo");
        diccionario.Add("week", "semana");
        diccionario.Add("case", "caso");
        diccionario.Add("point", "punto/tema");
        diccionario.Add("government", "gobierno");
        diccionario.Add("company", "empresa/compañía");
    }

    static void MostrarMenu()
    {
        while (true)
        {
            Console.WriteLine("\n==================== MENÚ ====================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    TraducirFrase();
                    break;
                case "2":
                    AgregarPalabra();
                    break;
                case "0":
                    Console.WriteLine("¡Hasta pronto!");
                    return;
                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;
            }
        }
    }

    static void TraducirFrase()
    {
        Console.Write("Ingrese la frase a traducir: ");
        string frase = Console.ReadLine();
        
        if (string.IsNullOrWhiteSpace(frase))
        {
            Console.WriteLine("No se ingresó ninguna frase.");
            return;
        }

        string[] palabras = frase.Split(' ');
        List<string> fraseTraducida = new List<string>();

        foreach (string palabra in palabras)
        {
            // Limpiar la palabra de signos de puntuación
            string palabraLimpia = new string(palabra.Where(c => !char.IsPunctuation(c)).ToArray()).ToLower();
            
            if (diccionario.ContainsKey(palabraLimpia))
            {
                fraseTraducida.Add(diccionario[palabraLimpia]);
            }
            else
            {
                // Mantener la palabra original con su puntuación
                fraseTraducida.Add(palabra);
            }
        }

        Console.WriteLine("Traducción: " + string.Join(" ", fraseTraducida));
    }

    static void AgregarPalabra()
    {
        Console.Write("Ingrese la palabra en inglés: ");
        string ingles = Console.ReadLine()?.Trim().ToLower();
        
        Console.Write("Ingrese la traducción al español: ");
        string español = Console.ReadLine()?.Trim();

        if (string.IsNullOrWhiteSpace(ingles) || string.IsNullOrWhiteSpace(español))
        {
            Console.WriteLine("Error: Ambos campos deben contener texto.");
            return;
        }

        if (diccionario.ContainsKey(ingles))
        {
            Console.WriteLine("La palabra ya existe en el diccionario.");
            Console.WriteLine($"Traducción actual: {diccionario[ingles]}");
            Console.Write("¿Desea actualizarla? (s/n): ");
            
            if (Console.ReadLine()?.ToLower() != "s")
            {
                return;
            }
        }

        diccionario[ingles] = español;
        Console.WriteLine($"Palabra '{ingles}' agregada/actualizada correctamente.");
    }
}