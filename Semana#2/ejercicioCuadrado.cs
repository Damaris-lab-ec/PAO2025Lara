using System;

// La clase Cuadrado representa un cuadrado con un lado
public class Cuadrado
{
    // Campo privado que representa el lado del cuadrado
    private double lado;

    // Constructor que inicializa el lado del cuadrado
    public Cuadrado(double lado)
    {
        this.lado = lado;
    }

    // CalcularArea es una función que devuelve un valor double,
    // se utiliza para calcular el área de un cuadrado
    public double CalcularArea()
    {
        return lado * lado;
    }

    // CalcularPerimetro devuelve el perímetro del cuadrado
    public double CalcularPerimetro()
    {
        return 4 * lado;
    }
}
