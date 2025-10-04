public class Traductor
{
    // El diccionario almacena la palabra en Español (Key) y su traducción en Inglés (Value).
    private static System.Collections.Generic.Dictionary<string, string> diccionario = new System.Collections.Generic.Dictionary<string, string>(System.StringComparer.OrdinalIgnoreCase)
    {
        // Palabras iniciales (mínimo 10 requerido)
        {"tiempo", "time"},
        {"persona", "person"},
        {"año", "year"},
        {"día", "day"},
        {"cosa", "thing"},
        {"hombre", "man"},
        {"mundo", "world"},
        {"vida", "life"},
        {"mano", "hand"},
        {"ojo", "eye"},
        {"mujer", "woman"},
        {"lugar", "place"},
        {"trabajo", "work"},
        {"punto", "point"},
        {"gobierno", "government"}
    };

    public static void Main(string[] args)
    {
        System.Console.OutputEncoding = System.Text.Encoding.UTF8; // Asegura la correcta visualización de caracteres especiales
        bool continuar = true;

        while (continuar)
        {
            MostrarMenu();
            string opcion = System.Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    TraducirFrase();
                    break;
                case "2":
                    AgregarPalabra();
                    break;
                case "0":
                    continuar = false;
                    System.Console.WriteLine("\n¡Gracias por usar el traductor! Adiós.");
                    break;
                default:
                    System.Console.WriteLine("\nOpción no válida. Por favor, ingrese 1, 2 o 0.");
                    break;
            }

            if (continuar)
            {
                System.Console.WriteLine("\nPresione cualquier tecla para continuar...");
                System.Console.ReadKey();
            }
        }
    }

    /// <summary>
    /// Muestra el menú de opciones en la consola.
    /// </summary>
    private static void MostrarMenu()
    {
        System.Console.Clear();
        System.Console.WriteLine("==================== TRADUCTOR BÁSICO ====================");
        System.Console.WriteLine("1. Traducir una frase (Español -> Inglés)");
        System.Console.WriteLine("2. Agregar palabras al diccionario (Español - Inglés)");
        System.Console.WriteLine("0. Salir");
        System.Console.WriteLine("==========================================================");
        System.Console.Write("\nSeleccione una opción: ");
    }

    /// <summary>
    /// Permite al usuario traducir una frase completa, solo traduciendo las palabras encontradas.
    /// </summary>
    private static void TraducirFrase()
    {
        System.Console.Clear();
        System.Console.WriteLine("--- TRADUCIR UNA FRASE ---");
        System.Console.Write("Ingrese la frase en español: ");
        string fraseOriginal = System.Console.ReadLine();

        if (string.IsNullOrWhiteSpace(fraseOriginal))
        {
            System.Console.WriteLine("No se ingresó ninguna frase.");
            return;
        }

        // Expresión regular para separar palabras (Grupo 1: palabra) de la puntuación (Grupo 2: puntuación).
        // Esto permite preservar la puntuación y espacios correctamente.
        string patron = @"(\w+)(\W*)";

        string fraseTraducida = System.Text.RegularExpressions.Regex.Replace(fraseOriginal, patron, (match) =>
        {
            // Grupo 1: La palabra real (e.g., "día", "hermoso")
            string palabraOriginal = match.Groups[1].Value;
            // Grupo 2: La puntuación o espacio que sigue (e.g., ",", " ")
            string puntuacion = match.Groups[2].Value;

            // Normalizar la palabra para la búsqueda (todo minúsculas)
            string palabraNormalizada = palabraOriginal.ToLower();

            // Intentar obtener la traducción
            if (diccionario.TryGetValue(palabraNormalizada, out string traduccion))
            {
                // Si se encuentra, usamos la traducción en inglés y re-adjuntamos la puntuación.
                // Se capitaliza la primera letra de la traducción para una mejor presentación.
                string traduccionCapitalizada = char.ToUpper(traduccion[0]) + traduccion.Substring(1);
                return traduccionCapitalizada + puntuacion;
            }
            else
            {
                // Si no se encuentra, se mantiene la palabra original con su puntuación.
                return palabraOriginal + puntuacion;
            }
        });

        System.Console.WriteLine("\n--- RESULTADO DE LA TRADUCCIÓN (Parcial) ---");
        System.Console.WriteLine($"Original: {fraseOriginal}");
        System.Console.WriteLine($"Traducción: {fraseTraducida}");
        System.Console.WriteLine("--------------------------------------------");
    }

    /// <summary>
    /// Permite al usuario añadir un nuevo par de palabras (Español - Inglés) al diccionario.
    /// </summary>
    private static void AgregarPalabra()
    {
        System.Console.Clear();
        System.Console.WriteLine("--- AGREGAR PALABRAS AL DICCIONARIO ---");

        System.Console.Write("Ingrese la palabra en ESPAÑOL (ej: lugar): ");
        string palabraEspanol = System.Console.ReadLine().Trim().ToLower();

        if (string.IsNullOrWhiteSpace(palabraEspanol))
        {
            System.Console.WriteLine("Entrada inválida. Debe ingresar una palabra en español.");
            return;
        }

        if (diccionario.ContainsKey(palabraEspanol))
        {
            System.Console.WriteLine($"La palabra '{palabraEspanol}' ya existe en el diccionario (Traducción: {diccionario[palabraEspanol]}).");
            System.Console.Write("¿Desea actualizar la traducción? (s/n): ");
            if (System.Console.ReadLine().Trim().ToLower() != "s")
            {
                return;
            }
        }

        System.Console.Write("Ingrese la traducción en INGLÉS (ej: place): ");
        string palabraIngles = System.Console.ReadLine().Trim().ToLower();
        
        if (string.IsNullOrWhiteSpace(palabraIngles))
        {
            System.Console.WriteLine("Entrada inválida. Debe ingresar una traducción en inglés.");
            return;
        }

        try
        {
            // Se añade o se actualiza la entrada
            diccionario[palabraEspanol] = palabraIngles;
            System.Console.WriteLine($"\n¡Éxito! Se ha agregado/actualizado la palabra '{palabraEspanol}' con la traducción '{palabraIngles}'.");
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine($"Ocurrió un error al agregar la palabra: {ex.Message}");
        }
    }
}
