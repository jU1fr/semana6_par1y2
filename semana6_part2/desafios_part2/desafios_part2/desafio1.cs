using System;

public class Rectangulo
{
    // Variables de instancia
    private double alto;
    private double largo;

    // Constructor
    public Rectangulo(double alto, double largo)
    {
        this.alto = alto;
        this.largo = largo;
    }

    // Propiedades de solo lectura
    public double Alto
    {
        get { return alto; }
    }

    public double Largo
    {
        get { return largo; }
    }

    // Propiedad de solo lectura calculada
    public double SuperficieFrontal
    {
        get { return Alto * Largo; }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Crear un rectángulo
        Rectangulo rectangulo = new Rectangulo(5, 10);

        // Mostrar información del rectángulo
        Console.WriteLine("Alto del rectángulo: " + rectangulo.Alto);
        Console.WriteLine("Largo del rectángulo: " + rectangulo.Largo);
        Console.WriteLine("Superficie frontal del rectángulo: " + rectangulo.SuperficieFrontal);
    }
}

