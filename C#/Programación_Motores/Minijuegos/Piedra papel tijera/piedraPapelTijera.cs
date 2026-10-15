//Programacion y motores con Salva
//
//
//
//
//
//
//  MOTORES VIDEOJUEGOS: MINIJUEGOS
//
//  Ejercicios clase 15_10_26
//
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class PiedraPapelTijera
    {
        static void Main(string[] args)
        {
            //
            //  Rondas debe ser impar y mayor que cero, condición para terminar a parte de ganar o perder: agotar rondas o alcanzar maximoRondasGanable
            //

            int numRondas, puntosJugador = 0, puntosIA = 0, tiradaJugador = 0;
            bool jugamos = false;

            Console.WriteLine();
            Console.WriteLine("Bienvenido al piedra papel tijeras, cuantas rondas quieres jugar? PD: El número de rondas debe ser impar para que funcione. ");
            Console.Write("Numero de rondas:   ");
            numRondas = int.Parse(Console.ReadLine() ?? "0");
            
            int maximoRondasGanable = numRondas / 2 + 1;
            // Mensaje debug para mostrar el maximo de rondas ganables
            Console.WriteLine("     Rondas ganables: " + maximoRondasGanable + "     ");

            // Comprobemos que iniciamos la partida correctamente
            while(jugamos == false)
            {
                if (numRondas % 2 != 0 && numRondas > 0)
                {
                    Console.WriteLine("---------Iniciando partida con " + numRondas + " rondas---------");
                    jugamos = true;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("ERROR, vuelve a introducir un número de rondas correcto. PD El número de rondas no puede ser negativo.");
                    Console.Write("Numero de rondas:   ");
                    numRondas = int.Parse(Console.ReadLine() ?? "0");     
                }          
            }

            // Dentro de aquí veremos la lógica del juego
            if(jugamos == true)
            {
                int rondaActual = 0;

                while(jugamos == true)
                {
                    rondaActual++;

                    // Tres condicines para terminar la partida; ganas, pierdes, se agotan las rondas.
                    if(puntosIA == maximoRondasGanable)
                    {
                        Console.WriteLine("     La IA te ha ganado     ");
                        Console.WriteLine("---------Partida terminada---------");
                        return;
                    }
                    if(puntosJugador == maximoRondasGanable)
                    {
                        Console.WriteLine("     El jugador ha ganado     ");
                        Console.WriteLine("---------Partida terminada---------");
                        return;
                    }
                    if (numRondas == 0 && puntosJugador > puntosIA)
                    {
                        Console.WriteLine("     Se terminan las rondas, has ganado     ");
                        Console.WriteLine("---------Partida terminada---------");
                        return;
                    }
                    if (numRondas == 0 && puntosIA > puntosJugador)
                    {
                        Console.WriteLine("     Se terminan las rondas, la IA ha ganado     ");
                        Console.WriteLine("---------Partida terminada---------");
                        return;
                    }

                    //Aquí empieza la ronda
                    Console.WriteLine();
                    Console.Write("Piedra 1 - Papel 2 - Tijeras 3   ¿Cual eliges?    ");
                    tiradaJugador = int.Parse(Console.ReadLine() ?? "0");

                    if(tiradaJugador == 1 || tiradaJugador == 2 || tiradaJugador == 3)
                    {
                        Random tiradaAleatoria = new Random();
                        int tiradaIA = tiradaAleatoria.Next(1,4);

                        Console.WriteLine();
                        Console.WriteLine("---------Ronda: "+ rondaActual +"---------");
                        Console.WriteLine(tiradaJugador + "  <-Jugador / IA->  " + tiradaIA);

                        // Aquí entran los casos distintos de las tiradas
                        if(numRondas > 0)
                        {
                            if(tiradaJugador == 1 && tiradaIA == 1)
                            {
                                Console.WriteLine("Empate, rondas restantes " + numRondas);
                            }
                            else if(tiradaJugador == 2 && tiradaIA == 2)
                            {
                                Console.WriteLine("Empate, rondas restantes " + numRondas);
                            }
                            else if(tiradaJugador == 3 && tiradaIA == 3)
                            {
                                Console.WriteLine("Empate, rondas restantes " + numRondas);
                            }                                                    
                            else if(tiradaJugador == 1 && tiradaIA == 2)
                            {
                                Console.WriteLine("Pierdes la ronda, rondas restantes " + numRondas);
                                puntosIA++;
                            }
                            else if(tiradaJugador == 1 && tiradaIA == 3)
                            {
                                Console.WriteLine("Ganas la ronda, rondas restantes " + numRondas);
                                puntosJugador++;

                            }
                            else if(tiradaJugador == 2 && tiradaIA == 1)
                            {
                                Console.WriteLine("Ganas la ronda, rondas restantes " + numRondas);
                                puntosJugador++;
                            }
                            else if(tiradaJugador == 2 && tiradaIA == 3)
                            {
                                Console.WriteLine("Pierdes la ronda, rondas restantes " + numRondas);
                                puntosIA++;
                            }
                            else if(tiradaJugador == 3 && tiradaIA == 1)
                            {
                                Console.WriteLine("Pierdes la ronda, rondas restantes " + numRondas);
                                puntosIA++;
                            }
                            else if(tiradaJugador == 3 && tiradaIA == 2)
                            {
                                Console.WriteLine("Ganas la ronda, rondas restantes " + numRondas);
                                puntosJugador++;
                            }
                            else
                            {
                                Console.WriteLine("Fuera de casos programados, forzando cierre.");
                                return;
                            }
                            numRondas--;
                        }
                        else
                        {
                            jugamos = false;
                        }
                        Console.WriteLine("El jugador lleva: " + puntosJugador + "  ----  La IA lleva:  " + puntosIA);
                    }
                    else
                    {
                        Console.Write("Error introduciendo numero.");
                    }
                }
            }
            
            // En caso de error forzamos el cierre
            if(jugamos == false)
            {
                Console.Write("---------Forzando cierre---------");
                return;
            }
        }
    }
}