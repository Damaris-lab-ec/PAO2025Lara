using System;

class ListaEnlazada
{
    public Nodo cabeza;

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

        cabeza = anterior;
    }
}

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
