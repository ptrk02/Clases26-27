//Programacion y motores con Salva
//
//
//
//
//
//
//  MOTORES VIDEOJUEGOS: MINIJUEGOS
//
//  Ejercicios clase _10_26
//
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class AdivinarNumero
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al minijuego. ");
            Console.Write("Numero de intentos: ");
            int numeroIntentos = int.Parse(Console.ReadLine() ?? "0");

            // Comprobemos correctamente que iniciamos la partida
            while (numeroIntentos <= 0)
            {
                Console.WriteLine("Error introduciendo cifra, intentalo otra vez.");
                Console.Write("Numero de intentos: ");
                numeroIntentos = int.Parse(Console.ReadLine() ?? "0");
            }

            // Calculemos el numero el numero secreto
            Random numeroAleatorio = new Random();
            int numeroSecreto = numeroAleatorio.Next(1, numeroIntentos * 2);
            
            // Aqui empezara la ronda
            while(numeroIntentos != 0)
            {
                Console.WriteLine("-----Iniciando partida-----");

                // Debug para mostrar numero secreto
                //Console.WriteLine("El numero secreto es: " + numeroSecreto);

                Console.Write("Que numero crees que es: ");
                int numeroJugador = int.Parse(Console.ReadLine() ?? "0");

                // Comprobemos si ha ganado
                if (numeroJugador == numeroSecreto)
                {
                    Console.WriteLine("Correcto, has acertado.");
                    Console.WriteLine("-----Partida finalizada-----");
                    return;
                }
                else
                {
                    Console.WriteLine("Incorrecto, has fallado.");
                    numeroIntentos--;
                    Console.WriteLine("Te quedan " + numeroIntentos + " intentos.");
                }
            }
            Console.WriteLine("-----Partida finalizada-----");
            return;
        }
    }
}