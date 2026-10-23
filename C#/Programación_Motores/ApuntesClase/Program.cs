//Programacion y motores con Salva
//
//
//
//
//
//
//  MOTORES VIDEOJUEGOS: EJEMPLOS FUNCIONES
//
//  Ejercicios clase 23_10_26
//
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class ApunteRandom
    {
        static void Main(string[] args)
        {
            // LLamada a funciones
            Parar10();
        }
        static void Parar10()
        {
            int numero;
            bool continuar = true;

            while (continuar == true)
            {
                Console.Write("Dame un numero: ");
                numero = Int32.Parse(Console.ReadLine() ?? "0");

                if (numero == 10 || numero == 100)
                {
                    continuar = false;
                    Console.Write("Paramos");
                }
            }
        }
    }
}