using System;

class Program
{
    static void Main()
    {
        double suma = 0;
        int contador = 0;
        bool continuarIngresando = true;

        Console.WriteLine("Ingrese los puntajes del estudiante (1-10). Escriba 'fin' cuando haya terminado.");

        while (continuarIngresando)
        {
            Console.Write("Ingrese el puntaje (o 'fin' para terminar): ");
            string entrada = Console.ReadLine();

            if (entrada.ToLower() == "fin")
            {
                continuarIngresando = false;
            }
            else
            {
                if (double.TryParse(entrada, out double puntaje) && puntaje >= 1 && puntaje <= 10)
                {
                    suma += puntaje;
                    contador++;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número entre 1 y 10.");
                }
            }
        }

        if (contador > 0)
        {
            double promedio = suma / contador;
            Console.WriteLine($"El promedio del estudiante es: {promedio:F2}");
        }
        else
        {
            Console.WriteLine("No se ingresaron puntajes.");
        }

        Console.ReadLine(); // Mantener la consola abierta
    }
}