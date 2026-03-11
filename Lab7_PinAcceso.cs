using System;

class Program
{
    static void Main()
    {
        const string PIN_CORRECTO = "1234";
        string pinIngresado;
        int intentos = 0;
        const int MAX_INTENTOS = 3;
        bool accesoConcedido = false;

        do
        {
            intentos++;
            Console.Write($"Intento {intentos}/{MAX_INTENTOS} - Ingrese su PIN: ");
            pinIngresado = Console.ReadLine();

            if (pinIngresado == PIN_CORRECTO)
            {
                accesoConcedido = true;
                Console.WriteLine("Acceso concedido.");
            }
            else
            {
                Console.WriteLine("PIN incorrecto.");
                

                if (intentos == MAX_INTENTOS)
                {
                    Console.WriteLine("Cuenta bloqueada.");
                }
            }

        } while (!accesoConcedido && intentos < MAX_INTENTOS);

        Console.WriteLine("\nFin del proceso de seguridad.");
    }
}
