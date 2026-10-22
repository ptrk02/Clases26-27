//  Programacion y motores con Salva
//
//
//
//
//
//
//  MOTORES VIDEOJUEGOS: MINIJUEGOS
//
//  Ejercicios clase 21_10_26
//
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class BlackJack
    {
        static void Main(string[] args)
        {
            int opcionIniciamos;
            int opcionTiramos = 0;
            int opcionBonificador = 0;
            int numRonda = 1;
            int puntosIA = 0;
            int puntosJugador = 0;
            bool iniciamosPartida = false;
            bool plantadoIA = false;
            bool plantadoJugador = false;
            bool seguimosTirando = false;
            bool opcionCorrecta = false;
            
            Console.WriteLine();
            Console.WriteLine("Inteligencia Artificial: Bienvenido al Black Jack por terminal, cada ronda tiraremos un dado de seis caras y el que se acerque más a 21 puntos gana.");

            // Comprobemos si iniciamos la partida correctamente
            do
            {
                Console.Write("¿Deseas iniciar la partida?  1) Sí    2) No: ");
                opcionIniciamos = int.Parse(Console.ReadLine() ?? "0");
                Console.WriteLine();

                if(opcionIniciamos == 1)
                {
                    Console.WriteLine("Iniciando partida...");
                    iniciamosPartida = true;
                }
                else if(opcionIniciamos == 2)
                {
                    Console.WriteLine("No la inciamos.");
                }
                else
                {
                    Console.WriteLine("Error introduciendo opción, intentalo otra vez.");
                }
            }while(iniciamosPartida == false);

            // Iniciamos partida
            while(iniciamosPartida == true)
            {
                // Aquí empiezan las rondas
                do
                {
                    // Comprobamos al princípio de la ronda que no se hayan plantado los jugadores en la ronda anterior.
                    if((plantadoJugador == true && puntosJugador > puntosIA) || (plantadoIA == true && puntosIA > puntosJugador))
                    {
                        seguimosTirando = false;
                    }

                    Console.WriteLine();
                    Console.WriteLine("----------");
                    Console.WriteLine("Hemos iniciado la "+ numRonda + "ª ronda");
                    Console.WriteLine();
                    Console.WriteLine("----------");

                    Random numeroAleatorio = new Random();
                    if(plantadoIA == false)
                    {
                        int tiradaIA = numeroAleatorio.Next(1,7);
                        // Debug para mostrar los puntos de la IA
                        //Console.WriteLine("La IA a sacado un: " + tiradaIA);
                        puntosIA = puntosIA + tiradaIA;
                    }
                    else
                    {
                        Console.WriteLine("La IA está plantada.");
                    }

                    if(plantadoJugador == false)
                    {
                        int tiradaJugador = numeroAleatorio.Next(1,7);
                        Console.WriteLine("El jugador ha sacado un: " + tiradaJugador);

                        // EXTRA Bonificador de tirada
                        if(tiradaJugador == 1)
                        {
                            Console.WriteLine("!EXTRA! Al sacar un 1 puedes usar un comodín y cambiar la tirada por un 6");
                            Console.Write("¿Quieres usarlo?   1) Sí   2) No: ");
                            opcionBonificador = int.Parse(Console.ReadLine() ?? "0");
                            Console.WriteLine();

                            if(opcionBonificador == 1)
                            {
                                Console.WriteLine("Bonificador usado, tirada cambiada por 6");
                                tiradaJugador = 6;
                            }
                            else
                            {
                                Console.WriteLine("Perdiste la oportunidad.");
                            }
                        }
                        puntosJugador = puntosJugador + tiradaJugador;
                    }
                    else
                    {
                        Console.WriteLine("El jugador está plantado.");
                    }

                    if(plantadoIA == true && plantadoJugador == true)
                    {
                        seguimosTirando = false;
                    }

                    Console.WriteLine();
                    Console.WriteLine("----------");
                    // Debug para mostrar puntos de la IA
                    //Console.WriteLine("Puntos totales de la IA: " + puntosIA);
                    Console.WriteLine("Puntos totales del jugador: " + puntosJugador);
                    Console.WriteLine();
                    
                    if(plantadoJugador == false)
                    {
                        Console.Write("¿Sigues o te plantas? 1) Sigues 2) Te plantas: ");
                        opcionTiramos = int.Parse(Console.ReadLine() ?? "0");
                        Console.WriteLine();   
                    }

                    // Comportamiento de la IA
                    if (puntosIA == 21)
                    {
                        seguimosTirando = false;
                    }
                    else if(puntosIA > 15)
                    {
                        Console.WriteLine();
                        Console.WriteLine("----------");
                        Console.WriteLine("La IA está plantada...");
                        plantadoIA = true;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("La IA sigue...");
                        seguimosTirando = true;
                    }

                    // Condiciones del jugador que terminan directamente la partida
                    if(puntosJugador > 21)
                    {
                        Console.WriteLine();
                        Console.WriteLine("El jugador se ha pasado");
                        seguimosTirando = false;
                    }
                    else if(puntosJugador == 21)
                    {
                        seguimosTirando = false;
                    }

                    if(opcionTiramos == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("----------");
                        Console.WriteLine("Siguiente ronda...");
                        seguimosTirando = true;
                    }
                    else if(opcionTiramos == 2)
                    {
                        Console.WriteLine("Estás plantado...");
                        plantadoJugador = true;
                    }
                    else
                    {
                        // Bucle para asegurar la opcion dentro del rango deseado
                        while(opcionCorrecta == false)
                        {
                            Console.WriteLine("Error introduciendo opción, intentalo otra vez.");
                            Console.WriteLine();
                            Console.Write("¿Sigues o te plantas? 1) Sigues 2) Te plantas: ");
                            opcionTiramos = int.Parse(Console.ReadLine() ?? "0");

                            if(opcionTiramos == 1)
                            {
                                Console.WriteLine();
                                Console.WriteLine("----------");
                                Console.WriteLine("Siguiente ronda...");
                                plantadoJugador = false;
                                opcionCorrecta = true;
                                seguimosTirando = true;
                            }
                            else if(opcionTiramos == 2)
                            {
                                Console.WriteLine("Estás plantado...");
                                plantadoJugador = true;
                            }
                        }
                    }
                    numRonda++;
                } while (seguimosTirando == true);

                // Forzamos fin de la partida.
                iniciamosPartida = false;
            }

                // Comprobamos los resultados al finalizar partida
                Console.WriteLine("----------");
                Console.WriteLine("Calculando resultados...");
                Console.WriteLine("Puntos totales de la IA: " + puntosIA);
                Console.WriteLine("Puntos totales del jugador: " + puntosJugador);
                Console.WriteLine("----------");
                Console.WriteLine();

                // Resultado final
                Console.WriteLine("----------");
                if(puntosIA > puntosJugador && puntosIA <= 21)
                {
                    Console.WriteLine("Has perdido!");
                }
                else if(puntosJugador > puntosIA && puntosJugador <= 21)
                {
                    Console.WriteLine("Me has ganado!");
                }
                else
                {
                    Console.WriteLine("Tenemos empate!");
                }
                Console.WriteLine("----------");
        }
    }
}