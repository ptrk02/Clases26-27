using System;

class Program
{
    static void Main()
    {
        int opcion;

        do
        {
            MostrarMenu();
            opcion = LeerOpcion(0, 3);
            ElegirOpcion(opcion);
        } while (opcion != 0);

        Console.WriteLine("\nFin del programa. Pulsa una tecla para salir...");    
        Console.ReadKey();
    }

    static void MostrarMenu()
    {
        Console.Clear();
        Console.WriteLine("\x1b[3J"); // Limpiar la pantalla en Windows y Linux]");
        Console.WriteLine("==========================");
        Console.WriteLine("===== MENÚ PRINCIPAL =====");
        Console.WriteLine("==========================");
        Console.WriteLine("1. Opción 1");
        Console.WriteLine("2. Opción 2");
        Console.WriteLine("3. Opción 3");
        Console.WriteLine("0. Salir");
        Console.WriteLine("==========================");
    }

    static void ElegirOpcion(int opcion)
    {
        switch (opcion)
        {
            case 1:
                Opcion1();
                break;
            case 2:
                Opcion2();
                break;
            case 3:
                Opcion3();
                break;
            case 0:
                Console.WriteLine("Saliendo del programa...");
                break;
        }

        if (opcion != 0)
        {
            Console.WriteLine("\nPulsa una tecla para continuar...");
            Console.ReadKey();
        }
    }

    static int LeerOpcion(int min, int max)
    {
        int valor;

        while (true)
        {
            Console.Write($"Elige una opción ({min}-{max}): ");
            string entrada = Console.ReadLine() ?? "0";

            if (!int.TryParse(entrada, out valor))
            {
                Console.WriteLine("Error: debes introducir un número entero.");
            }
            else if (valor < min || valor > max)
            {
                Console.WriteLine($"Error: la opción debe estar entre {min} y {max}.");
            }
            else
            {
                return valor;
            }
        }
    }

    static void Opcion1()
    {
        Console.WriteLine("Ejecutando Opción 1...");
        // TODO: implementar
    }

    static void Opcion2()
    {
        Console.WriteLine("Ejecutando Opción 2...");
        // TODO: implementar
    }

    static void Opcion3()
    {
        Console.WriteLine("Ejecutando Opción 3...");
        // TODO: implementar
    }
}