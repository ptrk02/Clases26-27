//Programacion y motores con Salva
//
//
//
//
//
//
//  MOTORES VIDEOJUEGOS: MINIJUEGOS
//
//  Ejercicios clase 14_10_26
//
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class PiedraPapelTijera
    {
        static void Main(string[] args)
        {
            //
            //  Rondas debe ser impar y mayor que cero, condición de ganár: agotar rondas o alcanzar maximoRondasGanable
            //

            int numRondas, tiradaJugador, tiradaIA, puntosJugador, puntosIA;
            bool jugamos = false;

            Console.Write("Bienvenido al piedra papel tijeras, cuantas rondas quieres jugar?    ");
            numRondas = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("PD: El número de rondas debe ser impar para que funcione.");

            int maximoRondasGanable = numRondas / 2 + 1;

            if(numRondas % 2 == 0)
            {
                jugamos = false;
                Console.WriteLine("Debug sample text");
            }
            if (numRondas % 2 != 0)
            {
                jugamos = true;
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}