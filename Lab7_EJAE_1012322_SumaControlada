using System;

class Program
{
    static void Main()
    {
        int n = 0;

        while (n <= 0)
        {
            Console.Write("¿Cuántos números desea sumar? (N > 0): ");
            if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Error: Por favor, ingrese un número entero positivo.");
                n = 0; 
            }
        }

        double sumaTotal = 0;
        int contador = 1;

        while (contador <= n)
        {
            Console.Write($"Ingrese el número {contador}: ");
            if (double.TryParse(Console.ReadLine(), out double numero))
            {
                sumaTotal += numero;
                contador++;
            }
            else
            {
                Console.WriteLine("Entrada no válida. Intente de nuevo con ese número.");
            }
        }

        double promedio = sumaTotal / n;

        Console.WriteLine("\n----------------------------");
        Console.WriteLine($"El total de la suma es: {sumaTotal}");
        Console.WriteLine($"El promedio es: {promedio}");
        Console.WriteLine("----------------------------");
    }
}
