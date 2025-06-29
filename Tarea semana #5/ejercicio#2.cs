using System;
using System.Collections.Generic;
using System.Linq;

namespace LoteriaPrimitiva
{
    class Loteria
    {
        // Lista para guardar los números
        public List<int> Numeros { get; private set; }

        public Loteria()
        {
            Numeros = new List<int>();
        }

        // Método para pedir al usuario los números
        public void PedirNumeros()
        {
            Console.WriteLine("Introduce los 6 números ganadores de la Primitiva (1–49), sin repetir:");
            while (Numeros.Count < 6)
            {
                Console.Write($"Número {Numeros.Count + 1}: ");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out int num) || num < 1 || num > 49)
                {
                    Console.WriteLine("  → Debes introducir un entero entre 1 y 49.");
                    continue;
                }
                if (Numeros.Contains(num))
                {
                    Console.WriteLine("  → Ese número ya ha sido introducido, elige otro.");
                    continue;
                }

                Numeros.Add(num);
            }
        }

        // Método para ordenar y mostrar los números
        public void MostrarOrdenados()
        {
            var ordenados = Numeros.OrderBy(n => n).ToList();
            Console.WriteLine("\nNúmeros ganadores ordenados:");
            Console.WriteLine(string.Join("  ", ordenados));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Loteria primitiva = new Loteria();

            primitiva.PedirNumeros();
            primitiva.MostrarOrdenados();

            Console.WriteLine("\nPulsa cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
