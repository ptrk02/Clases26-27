//Programacion y motores con Salva
//
//
//
//
//
//
//  EJERCICIOS 1: CONDICIONES ANIDADAS 
//
//  Ejercicios clase 07_10_26
//
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class CondicionesAnidadas
    {
        static void Main(string[] args)
        {
            //
            // Ejercicio 1
            // Se cargan por teclado las puntuaciones de tres jugadores en una misma partida (las tres puntuaciones son distintas). Mostrar por pantalla cuál es el jugador ganador (el de mayor puntuación)
            //

            int jugador1, jugador2, jugador3;

            Console.Write("Puntuación jugador 1: ");
            jugador1 = Int32.Parse(Console.ReadLine());
            Console.Write("Puntuación jugador 2: ");
            jugador2 = Int32.Parse(Console.ReadLine());
            Console.Write("Puntuación jugador 3: ");
            jugador3 = Int32.Parse(Console.ReadLine());

            if(jugador1 > jugador2 && jugador1 > jugador3)
            {
                Console.WriteLine("El jugador ganador es el Jugador 1, con " + jugador1);
            }
            if(jugador2 > jugador1 && jugador2 > jugador3)
            {
                Console.WriteLine("El jugador ganador es el Jugador 2, con " + jugador2);
            }
            else
            {
                Console.WriteLine("El jugador ganador es el Jugador 3, con " + jugador3);
            }

            //
            //  Ejericicio 2
            //  Se ingresa por teclado la variación de vida de un personaje tras un combate (un número entero que representa daño recibido o vida recuperada). Mostrar una leyenda que indique si la variación es positiva (recuperó vida), nula (sin cambios) o negativa (recibió daño). 
            //

            float variacionVida;

            Console.Write("Daño recibido: ");
            variacionVida = float.Parse(Console.ReadLine());

            if(variacionVida > 0)
            {
                Console.WriteLine("El personaje recuperó vida.");
            }
            else if(variacionVida < 0)
            {
                Console.WriteLine("El personaje recibió daño.");
            }
            else
            {
                Console.WriteLine("El personaje no tuvo cambios en su vida.");
            }

        }
    }
}