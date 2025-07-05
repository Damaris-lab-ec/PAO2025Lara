public void Invertir()
{
    Nodo anterior = null;
    Nodo actual = cabeza;
    Nodo siguiente = null;
     while (actual != null)
    {
        siguiente = actual.siguiente;
        actual.siguiente = anterior;
        anterior = actual;
        actual = siguiente;
    }
        siguiente = actual.siguiente;
        actual.siguiente = anterior;
        anterior = actual;
        actual = siguiente;
    }

cabeza = anterior;
}

//Ejemplo de uso en Main():\\

class Program
{
    static void Main(string[] args)
    {
        ListaEnlazada lista = new ListaEnlazada();
        lista.AgregarAlFinal(10);
        lista.AgregarAlFinal(20);
        lista.AgregarAlFinal(30);
        lista.AgregarAlFinal(40);