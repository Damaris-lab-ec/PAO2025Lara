using System;

// La clase Circulo representa un círculo con su respectivo radio
public class Circulo
{
    // Campo privado que representa el radio del círculo
    private double radio;

    // inicializa el radio del círculo
    public Circulo(double radio)
    {
        this.radio = radio;
    }

    // CalcularArea es una función que devuelve un valor double,
    // se utiliza para calcular el área de un círculo usando el radio almacenado
    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    // CalcularPerimetro es una función que devuelve un valor double,
    // se utiliza para calcular el perímetro (circunferencia) de un círculo
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}
