using System;

public class Caja
{
    // Variables de instancia
    private double largo;
    private double ancho;
    private double alto;

    // Constructor
    public Caja(double largo, double ancho, double alto)
    {
        this.largo = largo;
        this.ancho = ancho;
        this.alto = alto;
    }

    // Método para calcular el volumen de la caja
    public double CalcularVolumen()
    {
        return largo * ancho * alto;
    }
}

public class desafio2
{
    public static void Main(string[] args)
    {
        Console.Write("Ingrese el número de cajas: ");
        int numCajas = int.Parse(Console.ReadLine());

        double volumenTotal = 0;

        // Loop para ingresar las dimensiones de las cajas
        for (int i = 1; i <= numCajas; i++)
        {
            Console.WriteLine($"\nIngrese las dimensiones de la caja {i}:");
            Console.Write("Largo: ");
            double largo = double.Parse(Console.ReadLine());
            Console.Write("Ancho: ");
            double ancho = double.Parse(Console.ReadLine());
            Console.Write("Alto: ");
            double alto = double.Parse(Console.ReadLine());

            // Crear objeto Caja
            Caja caja = new Caja(largo, ancho, alto);

            // Calcular el volumen de la caja y sumarlo al volumen total
            double volumenCaja = caja.CalcularVolumen();
            volumenTotal += volumenCaja;
        }

        // Calcular el volumen promedio
        double volumenPromedio = volumenTotal / numCajas;

        // Mostrar resultados
        Console.WriteLine($"\nVolumen total de las cajas: {volumenTotal}");
        Console.WriteLine($"Volumen promedio de las cajas: {volumenPromedio}");
    }
}
