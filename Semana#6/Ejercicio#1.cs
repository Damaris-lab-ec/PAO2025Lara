using System;

class Nodo
{
    public int valor;
    public Nodo siguiente;
    public Nodo(int valor)
    {
        this.valor = valor;
        this.siguiente = null;
    }
}
class ListaEnlazada
{
    public Nodo cabeza;

    public ListaEnlazada()
    {
        cabeza = null;
    }
     public void AgregarAlFinal(int valor)
    {
        Nodo nuevo = new Nodo(valor);
        if (cabeza == null)
        {
            cabeza = nuevo;
        }
        else
        {
Nodo actual = cabeza;
            while (actual.siguiente != null)
            {
                actual = actual.siguiente;
            }
            actual.siguiente = nuevo;
        }
    }
  public int ContarElementos()
    {
        int contador = 0;
        Nodo actual = cabeza;
        while (actual != null)
        {
            contador++;
            actual = actual.siguiente;
        }
        return contador;
    }
     public void Mostrar()
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            Console.Write(actual.valor + " -> ");
            actual = actual.siguiente;
        }
        Console.WriteLine("null");
    }
}
