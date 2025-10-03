
// Clase que representa un catálogo de revistas
public class CatalogoRevistas
{
    // Lista privada que almacena los títulos de las revistas
    private List<string> revistas;

    // Constructor que inicializa el catálogo con revistas predefinidas
    public CatalogoRevistas()
    {
        revistas = new List<string>(); // Inicializa la lista vacía

        revistas.Add("Don Quijote");
        revistas.Add("La Casa de Papel");
        revistas.Add("Harry Potter");
        revistas.Add("El País");
        revistas.Add("The New York Times");
        revistas.Add("la Barrera del no ");
        revistas.Add("Cien años de soledad");
        revistas.Add("El Señor de los Anillos");
        revistas.Add("1984");
        revistas.Add("la culpa es de la vaca");
        revistas.Add("Pollito ");
    }

    // Método para realizar la búsqueda iterativa de un título
    public bool BuscarTituloIterativo(string tituloBuscado)
    {
        // Convertimos el título buscado a minúsculas para una búsqueda insensible a mayúsculas/minúsculas
        string tituloNormalizado = tituloBuscado.ToLower();

        // Iteramos sobre cada título en el catálogo
        foreach (string revista in revistas)
        {
            // Normalizamos el título de la revista en el catálogo para comparar
            if (revista.ToLower().Contains(tituloNormalizado)) // Usamos Contains para búsqueda parcial
            {
                return true;
            }
        }
        return false;
    }

    // Método para realizar la búsqueda recursiva de un título (Opcional, pero se puede añadir)
    // Para una búsqueda recursiva, normalmente se necesita un índice y una función auxiliar.
    public bool BuscarTituloRecursivo(string tituloBuscado)
    {

        return BuscarTituloRecursivoHelper(tituloBuscado.ToLower(), 0);
    }

    // Método auxiliar para la búsqueda recursiva
    private bool BuscarTituloRecursivoHelper(string tituloNormalizado, int indice)
    {

        if (indice >= revistas.Count)
        {
            return false;
        }

        // Si el título actual contiene el título buscado
        if (revistas[indice].ToLower().Contains(tituloNormalizado))
        {
            return true; // Título encontrado
        }


        return BuscarTituloRecursivoHelper(tituloNormalizado, indice + 1);
    }


    // Método para mostrar todas las revistas del catálogo
    public void MostrarCatalogo()
    {
        Console.WriteLine("\n--- Catálogo de Revistas ---"); // Encabezado del catálogo
        foreach (string revista in revistas) // Recorre cada revista
        {
            Console.WriteLine($"- {revista}");
        }
        Console.WriteLine("---------------------------\n"); // Línea separadora final
    }
}

// Clase principal del programa para la interacción con el usuario
class Program
{
    // Método principal que ejecuta el programa
    static void Main(string[] args)
    {
        CatalogoRevistas miCatalogo = new CatalogoRevistas();
        bool salir = false;

        // Bucle principal del menú
        while (!salir)
        {

            Console.WriteLine("--- Menú de Catálogo de Revistas ---");
            Console.WriteLine("1. Buscar título de revista (Iterativo)");
            Console.WriteLine("2. Buscar título de revista (Recursivo)");
            Console.WriteLine("3. Mostrar catálogo completo");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();
            Console.WriteLine();

            // Evalúa la opción seleccionada por el usuario
            switch (opcion)
            {
                case "1": // Opción de búsqueda iterativa
                    Console.Write("Ingrese el título a buscar: ");
                    string tituloABuscarIterativo = Console.ReadLine();

                    if (miCatalogo.BuscarTituloIterativo(tituloABuscarIterativo))
                    {
                        Console.WriteLine($"'{tituloABuscarIterativo}' -> Encontrado.");
                    }
                    else
                    {
                        Console.WriteLine($"'{tituloABuscarIterativo}' -> No encontrado.");
                    }
                    break;
                case "2": // Opción de búsqueda recursiva
                    Console.Write("Ingrese el título a buscar (recursivo): ");
                    string tituloABuscarRecursivo = Console.ReadLine(); // Lee el título a buscar
                    // Realiza la búsqueda recursiva y muestra el resultado
                    if (miCatalogo.BuscarTituloRecursivo(tituloABuscarRecursivo))
                    {
                        Console.WriteLine($"'{tituloABuscarRecursivo}' -> Encontrado.");
                    }
                    else
                    {
                        Console.WriteLine($"'{tituloABuscarRecursivo}' -> No encontrado.");
                    }
                    break;
                case "3":
                    miCatalogo.MostrarCatalogo(); // Llama al método para mostrar todas las revistas
                    break;
                case "4":
                    salir = true; // Cambia la variable para terminar el bucle
                    Console.WriteLine("Saliendo de la aplicación. ¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Por favor, intente de nuevo.");
                    break;
            }
            Console.WriteLine();
        }
    }
}
