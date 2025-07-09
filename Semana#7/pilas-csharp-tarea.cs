using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
class BalanceoParentesis
{
    /// <summary>
    /// Verifica si una expresión matemática tiene paréntesis, llaves y corchetes balanceados.
    /// </summary>
    /// <param name="expresion">Cadena de entrada con la expresión matemática.</param>
    /// <returns>True si está balanceada, false si no.</returns>
    static bool EstaBalanceada(string expresion)
    {
        Stack<char> pila = new Stack<char>();

        foreach (char caracter in expresion)
        {
            if (caracter == '(' || caracter == '{' || caracter == '[')
            {
                pila.Push(caracter); // Agrega el símbolo de apertura a la pila
            }
            else if (caracter == ')' || caracter == '}' || caracter == ']')
            {
                if (pila.Count == 0) return false;

                char tope = pila.Pop(); // Extrae el último símbolo de apertura

                // Verifica que el símbolo coincida correctamente
                if ((caracter == ')' && tope != '(') ||
                    (caracter == '}' && tope != '{') ||
                    (caracter == ']' && tope != '['))
                {
                    return false;
                }
            }
        }

        return pila.Count == 0;
    }

    static void Main()
    {
        string entrada = "{7 + (8 * 5) - [(9 - 7) + (4 + 1)]}";
        Console.WriteLine("Expresión: " + entrada);

        if (EstaBalanceada(entrada))
            Console.WriteLine("Fórmula balanceada.");
        else
            Console.WriteLine("Fórmula NO balanceada.");
    }
}



class Torre
{
    public Stack<int> Discos { get; private set; }
    public string Nombre { get; private set; }

    public Torre(string nombre)
    {
        Nombre = nombre;
        Discos = new Stack<int>();
    }

    public void MoverDiscoA(Torre destino)
    {
        int disco = Discos.Pop();
        destino.Discos.Push(disco);
        Console.WriteLine($"Mover disco {disco} de {Nombre} a {destino.Nombre}");
    }
}

class TorresDeHanoi
{
    /// <summary>
    /// Resuelve el problema de las Torres de Hanoi usando recursión y pilas.
    /// </summary>
    /// <param name="n">Número de discos.</param>
    /// <param name="origen">Torre de origen.</param>
    /// <param name="auxiliar">Torre auxiliar.</param>
    /// <param name="destino">Torre destino.</param>
    static void Resolver(int n, Torre origen, Torre auxiliar, Torre destino)
    {
        if (n == 1)
        {
            origen.MoverDiscoA(destino);
        }
        else
        {
            Resolver(n - 1, origen, destino, auxiliar);
            origen.MoverDiscoA(destino);
            Resolver(n - 1, auxiliar, origen, destino);
        }
    }

    static void Main()
    {
        int numeroDeDiscos = 3;
        Torre torreA = new Torre("A");
        Torre torreB = new Torre("B");
        Torre torreC = new Torre("C");

        // Inicializar los discos en la torre A
        for (int i = numeroDeDiscos; i >= 1; i--)
        {
            torreA.Discos.Push(i);
        }

        Console.WriteLine("Resolviendo Torres de Hanoi con 3 discos:\n");
        Resolver(numeroDeDiscos, torreA, torreB, torreC);
    }
}
