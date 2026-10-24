//Programacion y motores con Salva
//
//
//
//
//
//
//  MOTORES VIDEOJUEGOS: MINIJUEGOS
//
//  Ejercicios clase 24_10_26
//
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class PiedraPapelTijera
    {
        static int PedirRondas()
        {
            Console.Write("Numero de rondas:   ");
            int funcNumRondas = int.Parse(Console.ReadLine() ?? "0");

            return funcNumRondas;
        }
        static int PedirOpcion()
        {
            Console.Write("Piedra) 1 | Papel) 2 | Tijeras) 3   ¿Cual eliges?    ");
            int funcTiradaJugador = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine();

            return funcTiradaJugador;
        }
        static void Main(string[] args)
        {
            //
            //  Rondas debe ser impar y mayor que cero, condición de ganár: agotar rondas o alcanzar maximoRondasGanable
            //
            int puntosJugador = 0, puntosIA = 0;
            bool jugamos = false;

            Console.WriteLine("Bienvenido al piedra papel tijeras, cuantas rondas quieres jugar? PD: El número de rondas debe ser impar para que funcione. ");
            // EXTRA llamar a funcion de pedir numRondas
            int numRondas = PedirRondas();

            int maximoRondasGanable = numRondas / 2 + 1;
            // Debug para mostrar maximoRondasGanable
            //Console.WriteLine("     Rondas ganables: " + maximoRondasGanable + "     ");

            // Comprobemos que iniciamos correctamente la partida
            while(numRondas < 0 || (numRondas % 2 == 0))
            {
                Console.WriteLine("ERROR! cuantas rondas quieres jugar? PD: El número de rondas debe ser impar para que funcione. ");
                Console.Write("Numero de rondas:   ");
                numRondas = int.Parse(Console.ReadLine() ?? "0");
            }
            if (numRondas >= 0)
            {
                jugamos = true;
            }

            // Dentro de aquí veremos la lógica del juego
            do
            {
                Console.WriteLine();
                Console.WriteLine("---------Ronda: "+ numRondas + " ---------");

                // EXTRA llamar a función PedirOpcion
                int tiradaJugador = PedirOpcion();

                if(tiradaJugador == 1 || tiradaJugador == 2 || tiradaJugador == 3)
                {
                    Random tiradaAleatoria = new Random();
                    int tiradaIA = tiradaAleatoria.Next(1,4);

                    Console.WriteLine("Tirada: " + tiradaJugador + "  <-Jugador / IA->  " + tiradaIA);
                    
                    // Aquí estaran los casos distintos de las tiradas
                    if(numRondas != 0)
                    {
                        // EMPATE
                        if(tiradaJugador == tiradaIA)
                        {
                            Console.WriteLine("----------");
                            Console.WriteLine("Empate, esta ronda no cuenta, rondas restantes " + numRondas);
                            Console.WriteLine("----------");

                            if(puntosIA == maximoRondasGanable)
                            {
                                Console.WriteLine();
                                Console.WriteLine("La IA te ha ganado     ");
                                jugamos = false;
                            }
                            else if(puntosJugador == maximoRondasGanable)
                            {
                                Console.WriteLine();
                                Console.WriteLine("El jugador ha ganado     ");
                                jugamos = false;
                            }
                        }
                        // JUGADOR GANA
                        else if((tiradaJugador == 1 && tiradaIA == 3) || (tiradaJugador == 2 && tiradaIA == 1) || (tiradaJugador == 3 && tiradaIA == 2))
                        {
                            numRondas--;
                            Console.WriteLine("----------");
                            Console.WriteLine("Ganas la ronda, rondas restantes " + numRondas);
                            Console.WriteLine("----------");
                            puntosJugador++;

                            if(puntosIA == maximoRondasGanable)
                            {
                                Console.WriteLine();
                                Console.WriteLine("La IA te ha ganado     ");
                                jugamos = false;
                            }
                            else if(puntosJugador == maximoRondasGanable)
                            {
                                Console.WriteLine();
                                Console.WriteLine("El jugador ha ganado     ");
                                jugamos = false;
                            } 
                        }
                        // IA GANA
                        else
                        {
                            numRondas--;
                            Console.WriteLine("----------");
                            Console.WriteLine("Pierdes la ronda, rondas restantes " + numRondas);
                            Console.WriteLine("----------");
                            puntosIA++;

                            if(puntosIA == maximoRondasGanable)
                            {
                                Console.WriteLine();
                                Console.WriteLine("La IA te ha ganado     ");
                                jugamos = false;
                            }
                            else if(puntosJugador == maximoRondasGanable)
                            {
                                Console.WriteLine();
                                Console.WriteLine("El jugador ha ganado     ");
                                jugamos = false;
                            }
                        }
                    }
                    else if(numRondas == 0)
                    {
                        jugamos = false;
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("Error introduciendo numero.");
                    PedirOpcion();
                }
            }while(jugamos == true);

            // Terminamos la partida
            if(jugamos == false)
            {
                Console.WriteLine("---------Partida terminada---------");
                Console.WriteLine("Resultado final: " + puntosJugador + "--" + puntosIA);
                return;
            }
        }
    }
}