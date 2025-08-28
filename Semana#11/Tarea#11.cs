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
