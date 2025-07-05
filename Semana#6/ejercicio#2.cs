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
