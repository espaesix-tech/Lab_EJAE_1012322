using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el tipo de tarjeta (1, 2, 3 o otro): ");
        int tipoTarjeta = int.Parse(Console.ReadLine());

        Console.Write("Ingrese su límite de crédito actual: ");
        double limiteActual = double.Parse(Console.ReadLine());

        double porcentajeAumento;

        switch (tipoTarjeta)
        {
            case 1:
                porcentajeAumento = 0.25;
                break;
            case 2:
                porcentajeAumento = 0.35;
                break;
            case 3:
                porcentajeAumento = 0.40;
                break;
            default:
                porcentajeAumento = 0.50; 
                break;
        }

 
        double aumento = limiteActual * porcentajeAumento;
        double nuevoLimite = limiteActual + aumento;

      
        Console.WriteLine("\n--- Resumen de Actualización ---");
        Console.WriteLine($"Tipo de tarjeta: {tipoTarjeta}");
        Console.WriteLine($"Límite anterior: ${limiteActual}");
        Console.WriteLine($"Aumento aplicado: {porcentajeAumento * 100}% (+${aumento})");
        Console.WriteLine($"Nuevo límite de crédito: ${nuevoLimite}");
    }
}
