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

            int numRondas, puntosJugador = 0, puntosIA = 0, tiradaJugador = 0;
            bool jugamos = false;

            Console.WriteLine("Bienvenido al piedra papel tijeras, cuantas rondas quieres jugar? PD: El número de rondas debe ser impar para que funcione. ");
            Console.Write("Numero de rondas:   ");
            numRondas = int.Parse(Console.ReadLine() ?? "0");
            
            int maximoRondasGanable = numRondas / 2 + 1;
            Console.WriteLine("     Rondas ganables: " + maximoRondasGanable + "     ");

            // Comprobemos que iniciamos la partida
            if(numRondas % 2 == 0 && numRondas != 0)
            {
                jugamos = false;
            }
            if (numRondas % 2 != 0)
            {
                Console.WriteLine("---------Iniciando partida---------");
                jugamos = true;
            }
            else
            {
                while(jugamos == false)
                {
                    Console.Write("ERROR, vuelve a introducir un número de rondas correcto. PD El número de rondas debe ser impar para que funcione:   ");
                    Console.Write("Numero de rondas:   ");
                    numRondas = int.Parse(Console.ReadLine() ?? "0");

                    if(numRondas % 2 == 0 && numRondas != 0)
                    {
                        jugamos = false;
                    }
                    
                    if (numRondas % 2 != 0)
                    {
                        Console.WriteLine("---------Iniciando partida---------");
                        jugamos = true;
                    }
                }

            }

            Console.Write("Piedra 1 - Papel 2 - Tijeras 3   ¿Cual eliges?    ");

            // Dentro de aquí veremos la lógica del juego
            while(jugamos == true)
            {
                tiradaJugador = int.Parse(Console.ReadLine() ?? "0");

                if(tiradaJugador == 1 || tiradaJugador == 2 || tiradaJugador == 3)
                {
                    Random tiradaAleatoria = new Random();
                    int tiradaIA = tiradaAleatoria.Next(1,4);

                    Console.WriteLine(tiradaJugador + "  <-Jugador / IA->  " + tiradaIA);
                    
                    // Aquí estaran los casos distintos de las tiradas
                    if(numRondas != 1)
                    {
                        if(tiradaJugador == 1 && tiradaIA == 1)
                        {
                            numRondas--;
                            Console.WriteLine("Empate, rondas restantes " + numRondas);
                            Console.Write("Piedra 1 - Papel 2 - Tijeras 3   ¿Cual eliges?    ");
                            
                            if(puntosIA == maximoRondasGanable)
                            {
                                Console.Write("La IA te ha ganado     ");
                                jugamos = false;
                            }
                            else if(puntosJugador == maximoRondasGanable)
                            {
                                Console.Write("El jugador ha ganado     ");
                                jugamos = false;
                            }                          
                        }
                        else if(tiradaJugador == 2 && tiradaIA == 2)
                        {
                            numRondas--;
                            Console.WriteLine("Empate, rondas restantes " + numRondas);
                            Console.Write("Piedra 1 - Papel 2 - Tijeras 3   ¿Cual eliges?    ");

                            if(puntosIA == maximoRondasGanable)
                            {
                                Console.Write("La IA te ha ganado     ");
                                jugamos = false;
                            }
                            else if(puntosJugador == maximoRondasGanable)
                            {
                                Console.Write("El jugador ha ganado     ");
                                jugamos = false;
                            }
                        }
                        else if(tiradaJugador == 3 && tiradaIA == 3)
                        {
                            numRondas--;
                            Console.WriteLine("Empate, rondas restantes " + numRondas);
                            Console.Write("Piedra 1 - Papel 2 - Tijeras 3   ¿Cual eliges?    ");

                            if(puntosIA == maximoRondasGanable)
                            {
                                Console.Write("La IA te ha ganado     ");
                                jugamos = false;
                            }
                            else if(puntosJugador == maximoRondasGanable)
                            {
                                Console.Write("El jugador ha ganado     ");
                                jugamos = false;
                            }
                        }                                                    
                        else if(tiradaJugador == 1 && tiradaIA == 2)
                        {
                            numRondas--;
                            Console.WriteLine("Pierdes la ronda, rondas restantes " + numRondas);
                            Console.Write("Piedra 1 - Papel 2 - Tijeras 3   ¿Cual eliges?    ");
                            puntosIA++;

                            if(puntosIA == maximoRondasGanable)
                            {
                                Console.Write("La IA te ha ganado     ");
                                jugamos = false;
                            }
                            else if(puntosJugador == maximoRondasGanable)
                            {
                                Console.Write("El jugador ha ganado     ");
                                jugamos = false;
                            }
                        }
                        else if(tiradaJugador == 1 && tiradaIA == 3)
                        {
                            numRondas--;
                            Console.WriteLine("Ganas la ronda, rondas restantes " + numRondas);
                            Console.Write("Piedra 1 - Papel 2 - Tijeras 3   ¿Cual eliges?    ");
                            puntosJugador++;

                            if(puntosIA == maximoRondasGanable)
                            {
                                Console.Write("La IA te ha ganado     ");
                                jugamos = false;
                            }
                            else if(puntosJugador == maximoRondasGanable)
                            {
                                Console.Write("El jugador ha ganado     ");
                                jugamos = false;
                            }
                        }
                        else if(tiradaJugador == 2 && tiradaIA == 1)
                        {
                            numRondas--;
                            Console.WriteLine("Ganas la ronda, rondas restantes " + numRondas);
                            Console.Write("Piedra 1 - Papel 2 - Tijeras 3   ¿Cual eliges?    ");
                            puntosJugador++;

                            if(puntosIA == maximoRondasGanable)
                            {
                                Console.Write("La IA te ha ganado     ");
                                jugamos = false;
                            }
                            else if(puntosJugador == maximoRondasGanable)
                            {
                                Console.Write("El jugador ha ganado     ");
                                jugamos = false;
                            }
                        }
                        else if(tiradaJugador == 2 && tiradaIA == 3)
                        {
                            numRondas--;
                            Console.WriteLine("Pierdes la ronda, rondas restantes " + numRondas);
                            Console.Write("Piedra 1 - Papel 2 - Tijeras 3   ¿Cual eliges?    ");
                            puntosIA++;

                            if(puntosIA == maximoRondasGanable)
                            {
                                Console.Write("La IA te ha ganado     ");
                                jugamos = false;
                            }
                            else if(puntosJugador == maximoRondasGanable)
                            {
                                Console.Write("El jugador ha ganado     ");
                                jugamos = false;
                            }
                        }
                        else if(tiradaJugador == 3 && tiradaIA == 1)
                        {
                            numRondas--;
                            Console.WriteLine("Pierdes la ronda, rondas restantes " + numRondas);
                            Console.Write("Piedra 1 - Papel 2 - Tijeras 3   ¿Cual eliges?    ");
                            puntosIA++;

                            if(puntosIA == maximoRondasGanable)
                            {
                                Console.Write("La IA te ha ganado     ");
                                jugamos = false;
                            }
                            else if(puntosJugador == maximoRondasGanable)
                            {
                                Console.Write("El jugador ha ganado     ");
                                jugamos = false;
                            }
                        }
                        else if(tiradaJugador == 3 && tiradaIA == 2)
                        {
                            numRondas--;
                            Console.WriteLine("Ganas la ronda, rondas restantes " + numRondas);
                            Console.Write("Piedra 1 - Papel 2 - Tijeras 3   ¿Cual eliges?    ");
                            puntosJugador++;

                            if(puntosIA == maximoRondasGanable)
                            {
                                Console.Write("La IA te ha ganado     ");
                                jugamos = false;
                            }
                            else if(puntosJugador == maximoRondasGanable)
                            {
                                Console.Write("El jugador ha ganado     ");
                                jugamos = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Fuera de casos programados");
                            return;
                        }
                    }
                    else
                    {
                        jugamos = false;
                    }
                    Console.WriteLine("El jugador lleva: " + puntosJugador + "  ----  La IA lleva:  " + puntosIA);
                }
                else
                {
                    Console.Write("Error introduciendo numero   Piedra 1 - Papel 2 - Tijeras 3  ¿Cual eliges?   ");
                }
            }

            if(jugamos == false)
            {
                Console.Write("---------Partida terminada---------");
                return;
            }
        }
    }
}