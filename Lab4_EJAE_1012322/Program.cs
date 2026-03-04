using System;
using System.Numerics;
class Program
{
    static void Main()
    {
        Console.Write("Ingrese nuevo modelo de nave:");
        string modelo = Console.ReadLine();
        Console.WriteLine("Ingrese Capacidad de carga:");
        int Capacidad = int.Parse(Console.ReadLine());
        Console.WriteLine("Combustible actual:");
        float Combustible = float.Parse(Console.ReadLine());
        Console.WriteLine("¿Motor de salto activo?(true/false):");
        bool Salto = bool.Parse(Console.ReadLine());
        string estadoMotor = Salto ? "SI" : "NO";
        Console.WriteLine("Modelo " + modelo + " Agregado");
        Console.WriteLine("Capacidad de almacenamiento " + Capacidad + " Teragramos totales");
        Console.WriteLine("El tanque de combustible se encuentra a: " + Combustible + " Litros actuales");
        Console.WriteLine("Motor de salto, " + estadoMotor + " se encuentra el linea");
    }
}

