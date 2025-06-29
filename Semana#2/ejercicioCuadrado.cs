using System;

// La clase Cuadrado representa un cuadrado con un lado
public class Cuadrado
{
    private double lado;
     public Cuadrado(double lado)
    {
        this.lado = lado;
    }
    public double CalcularArea()
    {
        return lado * lado;
    }
