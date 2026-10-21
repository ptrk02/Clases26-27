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
    internal class BlackJack
    {
        static void Main(string[] args)
        {
            int iniciamos = 0;
            bool iniciamosPartida = false;

            int puntosIA = 0;
            int puntosJugador = 0;

            bool seguimosTirando = false;
            
            Console.WriteLine();
            Console.WriteLine("Inteligencia Artificial:   Bienvenido al Black Jack por terminal ");

            // Comprobemos si iniciamos la partida correctamente
            do
            {
                Console.WriteLine("¿Deseas iniciar la partida?  1) Sí    2) No");
                iniciamos = int.Parse(Console.ReadLine() ?? "0");
                Console.WriteLine();

                if(iniciamos == 1)
                {
                    Console.WriteLine("Iniciando partida.");
                    iniciamosPartida = true;
                }
                else if(iniciamos == 2)
                {
                    Console.WriteLine("No iniciamos partida.");
                }
                else
                {
                    Console.WriteLine("Error introduciendo número, intentalo otra vez.");
                }
            }while(iniciamosPartida == false);

            // Iniciamos partida
            while(iniciamosPartida == true)
            {
                Console.WriteLine();
                Console.WriteLine("----------");
                Console.WriteLine("Hemos iniciado la partida");

                // Aquí esta la lógica del juego
                do
                {
                    // Tirada del 1 al 6 cada vez que tiramos dado
                    Random numeroAleatorio = new Random();
                    int tirada = numeroAleatorio.Next(1,7);
                    
                } while (seguimosTirando == true);

                // Terminamos la partida
                iniciamosPartida = false;
            }
        }
    }
}