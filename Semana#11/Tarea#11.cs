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

