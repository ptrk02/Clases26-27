//Programacion y motores con Salva
//
//
//
//
//
//
//  MOTORES VIDEOJUEGOS: MINIJUEGOS
//
//  Ejercicios clase 19_10_26
//
using System;
using System.Diagnostics;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class AdivinarNumero
    {
        static int PedirIntetos()
        {
            Console.Write("Cuantos intentos vas a querer tener: ");
            int funcNumeroIntentos = int.Parse(Console.ReadLine() ?? "0");

            return funcNumeroIntentos;
        }
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Inteligencia Artificial:   Bienvenido al minijuego!  ¿Adivinarás el número que pienso? ");
            Console.WriteLine("Pista: El número que pienso ronda entre uno y el doble del siguiente que introduzcas.");
            Console.WriteLine();

            bool intentosCorrecto = false;

            // EXTRA llamar a funcion pedir intentos
            int numeroIntentos = PedirIntetos();

            Console.WriteLine();
            int numeroTemporal = 0;

            // Comprobemos correctamente que iniciamos la partida
            while (intentosCorrecto == false)
            {
                if (numeroIntentos > 0)
                {
                    intentosCorrecto = true;
                }
                if (numeroIntentos <= 0)
                {
                    Console.WriteLine("Error introduciendo cifra, intentalo otra vez.");
                    Console.Write("Cuantos intentos vas a querer tener: ");
                    numeroIntentos = int.Parse(Console.ReadLine() ?? "0");
                }                
            }

            // Calculemos el numero secreto
            Random numeroAleatorio = new Random();
            int numeroSecreto = numeroAleatorio.Next(1, (numeroIntentos * 2)+1);
            
            // Aqui empezara la ronda, si no, terminará el programa
            while(intentosCorrecto == true)
            {
                Console.WriteLine("---------------");

                Console.Write("Que número crees que es: ");
                int numeroJugador = int.Parse(Console.ReadLine() ?? "0");

                if(numeroJugador <= 0)
                {
                    Console.WriteLine("---------------");
                    Console.WriteLine("No puede ser un número negativo");
                    Console.WriteLine("---------------");
                }

                // Comprobemos si ha ganado o ha perdido la ronda
                if (numeroJugador == numeroSecreto)
                {
                    Console.WriteLine("Correcto! Has acertado el número.");
                    Console.WriteLine("-----Partida finalizada-----");
                    Console.WriteLine("El número secreto efectivamente era: " + numeroSecreto);
                    Console.WriteLine();
                    return;
                }
                else
                {
                    // EXTRA Comprobemos si has introducido dos veces consecutivas el mismo número
                    if (numeroJugador == numeroTemporal)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Has introducido el mismo número dos veces consecutivas, <Muy mal>");
                        Console.WriteLine("-----Partida finalizada-----");
                        Console.WriteLine();
                        return;
                    }
                    Console.WriteLine("Incorrecto, has fallado adivinando el número.");
                    numeroIntentos--;
                    Console.WriteLine("Te quedan " + numeroIntentos + " intento(s).");

                    if (numeroIntentos == 0)
                    {
                        intentosCorrecto = false;
                    }

                    numeroTemporal = numeroJugador;
                    Console.WriteLine("Además, no puedes volver a elegir el " + numeroTemporal + ", o si no, se termina el juego.");
                }
                Console.WriteLine("---------------");
                Console.WriteLine();
            }
            Console.WriteLine("-----Partida finalizada-----");
            
            // Debug para mostrar numero secreto
            Console.WriteLine("El número secreto era: " + numeroSecreto);
            Console.WriteLine();
            return;
        }
    }
}