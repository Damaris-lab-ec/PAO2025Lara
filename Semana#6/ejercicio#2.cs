using System;

// ... other using statements if needed

// Example of a class that might contain Invertir
public class ListaEnlazada // Assuming Invertir works with a linked list
{
    // You might have fields like 'cabeza' here
    private object cabeza; // Example field

    public void Invertir()
    {
        // Your existing Invertir method code
        // ...
        object siguiente = actual.siguiente; // Assuming actual is defined elsewhere, like a class field
        object actual.siguiente = anterior;
        object anterior = actual;
        object actual = siguiente;

        siguiente = actual.siguiente;
        actual.siguiente = anterior;
        anterior = actual;
        actual = siguiente;

        cabeza = anterior; // Ensure 'cabeza' is accessible in this context
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Your Main method code here
        // For example, to use Invertir:
        ListaEnlazada lista = new ListaEnlazada();
        // ... populate list ...
        lista.Invertir(); // Call the method
    }
}