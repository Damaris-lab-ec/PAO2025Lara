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
