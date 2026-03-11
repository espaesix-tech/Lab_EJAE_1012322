using System;

class Program
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n--- MENÚ DE CONVERSIÓN ---");
            Console.WriteLine("1. Convertir Celsius a Fahrenheit");
            Console.WriteLine("2. Convertir Fahrenheit a Celsius");
            Console.WriteLine("3. Convertir Kilómetros a Millas");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Error: Por favor, ingrese un número válido.");
                opcion = 0; // Para que el ciclo continúe
                continue;
            }


            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese grados Celsius: ");
                    double celsius = double.Parse(Console.ReadLine());
                    double fahr = (celsius * 9 / 5) + 32;
                    Console.WriteLine($"Resultado: {fahr:F2} °F");
                    break;

                case 2:
                    Console.Write("Ingrese grados Fahrenheit: ");
                    double f = double.Parse(Console.ReadLine());
                    double c = (f - 32) * 5 / 9;
                    Console.WriteLine($"Resultado: {c:F2} °C");
                    break;

                case 3:
                    Console.Write("Ingrese Kilómetros: ");
                    double km = double.Parse(Console.ReadLine());
                    double millas = km * 0.621371;
                    Console.WriteLine($"Resultado: {millas:F2} millas");
                    break;

                case 4:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                    break;
            }

        } while (opcion != 4); 
    }
}
