using System;
using System.Collections.Generic;
using System.Linq;

class Traductor
{
    private Dictionary<string, string> diccionario = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        {"Time", "tiempo"},
        {"Person", "persona"},
        {"Year", "año"},
        {"Way", "camino / forma"},
        {"Day", "día"},
        {"Thing", "cosa"},
        {"Man", "hombre"},
        {"World", "mundo"},
        {"Life", "vida"},
        {"Hand", "mano"},
        {"Part", "parte"},
        {"Child", "niño/a"},
        {"Eye", "ojo"},
        {"Woman", "mujer"},
        {"Place", "lugar"},
        {"Work", "trabajo"},
        {"Week", "semana"},
        {"Case", "caso"},
        {"Point", "punto / tema"},
        {"Government", "gobierno"},
        {"Company", "empresa / compañía"}
    };

    public void Iniciar()
    {
        bool continuar = true;
        while (continuar)
        {
            MostrarMenu();
            string opcion = Console.ReadLine();
            Console.WriteLine();

            switch (opcion)
            {
                case "1":
                    TraducirFrase();
                    break;
                case "2":
                    AgregarPalabras();
                    break;
                case "0":
                    continuar = false;
                    Console.WriteLine("¡Hasta la próxima!");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                    break;
            }
            Console.WriteLine("\n========================================\n");
        }
    }

    private void MostrarMenu()
    {
        Console.WriteLine("==================== MENÚ ====================");
        Console.WriteLine("1. Traducir una frase");
        Console.WriteLine("2. Agregar palabras al diccionario");
        Console.WriteLine("0. Salir");
        Console.Write("\nSeleccione una opción: ");
    }

    private void TraducirFrase()
    {
        Console.Write("Ingrese la frase a traducir: ");
        string frase = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(frase))
        {
            Console.WriteLine("La frase no puede estar vacía.");
            return;
        }

        var palabras = frase.Split(' ');
        var palabrasTraducidas = new List<string>();

        foreach (var palabra in palabras)
        {
            string palabraLimpia = LimpiarPalabra(palabra);
            string sufijo = palabra.Substring(palabraLimpia.Length);

            if (diccionario.ContainsKey(palabraLimpia))
            {
                palabrasTraducidas.Add(diccionario[palabraLimpia] + sufijo);
            }
            else
            {
                palabrasTraducidas.Add(palabra);
            }
        }
        Console.WriteLine($"\nTraducción: {string.Join(" ", palabrasTraducidas)}");
    }

    private void AgregarPalabras()
    {
        Console.Write("Ingrese la palabra en inglés: ");
        string ingles = Console.ReadLine();
        Console.Write("Ingrese la traducción en español: ");
        string espanol = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(ingles) || string.IsNullOrWhiteSpace(espanol))
        {
            Console.WriteLine("Ambas palabras deben ser válidas.");
            return;
        }

        string palabraClave = ingles.Trim();

        if (diccionario.ContainsKey(palabraClave))
        {
            Console.WriteLine($"La palabra '{palabraClave}' ya existe. Se actualizará la traducción.");
            diccionario[palabraClave] = espanol.Trim();
        }
        else
        {
            diccionario.Add(palabraClave, espanol.Trim());
            Console.WriteLine($"Palabra '{palabraClave}' agregada con éxito.");
        }
    }

    private string LimpiarPalabra(string palabra)
    {
        if (string.IsNullOrWhiteSpace(palabra))
        {
            return string.Empty;
        }

        int longitud = palabra.Length;
        while (longitud > 0 && char.IsPunctuation(palabra[longitud - 1]))
        {
            longitud--;
        }

        return palabra.Substring(0, longitud).Trim();
    }
}

class Program
{
    static void Main(string[] args)
    {
        var traductor = new Traductor();
        traductor.Iniciar();
    }
}