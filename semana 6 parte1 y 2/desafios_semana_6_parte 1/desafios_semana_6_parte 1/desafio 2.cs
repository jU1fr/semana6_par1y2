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
            // Asumir que el número es primo
            bool esPrimo = true;

            // Comprobar si el número es primo
            if (num == 1)
            {
                esPrimo = false; // El número 1 no es primo
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        esPrimo = false;
                        break; // Salir del bucle una vez encontrado un divisor
                    }
                }
            }

            // Imprimir el resultado
            if (esPrimo)
            {
                Console.WriteLine(num + " es un número primo.");
            }
            else
            {
                Console.WriteLine(num + " no es un número primo.");
            }
        }

        Console.ReadLine(); // Mantener la consola abierta
    }
}