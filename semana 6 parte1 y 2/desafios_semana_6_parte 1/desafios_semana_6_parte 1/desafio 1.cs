using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número entero positivo: ");
        int num = int.Parse(Console.ReadLine());

        // Verificar si el número ingresado es positivo
        if (num <= 0)
        {
            Console.WriteLine("Error: El número ingresado debe ser positivo.");
        }
        else
        {
            Console.WriteLine("Los números pares desde 1 hasta " + num + " son:");
            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        Console.ReadLine(); // Mantener la consola abierta
    }
}
