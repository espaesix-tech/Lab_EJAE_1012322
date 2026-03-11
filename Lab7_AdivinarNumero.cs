using System;

class Program
{
    static void Main()
    {
        Random aleatorio = new Random();
        int numeroSecreto = aleatorio.Next(1, 101); // El límite superior es exclusivo
        
        int intentoUsuario = 0;
        int cantidadIntentos = 0;

        Console.WriteLine("¡Bienvenido al juego! He pensado un número entre 1 y 100.");


        do
        {
            Console.Write("\nIngresa tu propuesta: ");
            

            if (!int.TryParse(Console.ReadLine(), out intentoUsuario))
            {
                Console.WriteLine("Por favor, ingresa un número válido.");
                continue;
            }


            if (intentoUsuario < 1 || intentoUsuario > 100)
            {
                Console.WriteLine("Aviso: El número debe estar entre 1 y 100. Este intento no cuenta.");
                continue; 
            }

            cantidadIntentos++;

            if (intentoUsuario < numeroSecreto)
            {
                Console.WriteLine("Más alto.");
            }
            else if (intentoUsuario > numeroSecreto)
            {
                Console.WriteLine("Más bajo.");
            }
            else
            {
                Console.WriteLine($"\n¡Correcto! El número era {numeroSecreto}.");
                Console.WriteLine($"Te tomó {cantidadIntentos} intentos adivinarlo.");
            }

        } while (intentoUsuario != numeroSecreto);

        Console.WriteLine("Gracias por jugar.");
    }
}
