
using System;

namespace MyApp
{
    internal class BlackJack
    {
        static void Main(string[] args)
        {
            int opcionIniciamos;
            int opcionTiramos = 0;
            int opcionBonificador;
            int numRonda = 1;
            int puntosIA = 0;
            int puntosJugador = 0;

            bool iniciamosPartida = false;
            bool plantadoIA = false;
            bool plantadoJugador = false;
            bool seguimosTirando = true;

            Random numeroAleatorio = new Random();

            Console.WriteLine("Bienvenido al BlackJack por terminal.");
            Console.WriteLine("Cada ronda tiraremos un dado de seis caras.");
            Console.WriteLine("El que se acerque más a 21 puntos sin pasarse gana.");

            // Comprobamos si iniciamos la partida
            do
            {
                Console.Write("¿Deseas iniciar la partida? 1) Sí  2) No: ");

                if (!int.TryParse(Console.ReadLine(), out opcionIniciamos))
                {
                    opcionIniciamos = 0;
                }

                if (opcionIniciamos == 1)
                {
                    Console.WriteLine("Iniciando partida...");
                    iniciamosPartida = true;
                }
                else if (opcionIniciamos == 2)
                {
                    Console.WriteLine("No iniciamos la partida.");
                    return;
                }
                else
                {
                    Console.WriteLine("Opción incorrecta.");
                }

            } while (iniciamosPartida == false);

            // Iniciamos partida
            while (iniciamosPartida == true)
            {
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("----------");
                    Console.WriteLine("Ronda " + numRonda);
                    Console.WriteLine("----------");

                    // Tirada de la IA
                    if (plantadoIA == false)
                    {
                        int tiradaIA = numeroAleatorio.Next(1, 7);
                        puntosIA += tiradaIA;

                        // Debug
                        // Console.WriteLine("La IA ha sacado: " + tiradaIA);
                    }
                    else
                    {
                        Console.WriteLine("La IA está plantada.");
                    }

                    // Tirada del jugador
                    if (plantadoJugador == false)
                    {
                        int tiradaJugador = numeroAleatorio.Next(1, 7);
                        Console.WriteLine("El jugador ha sacado: " + tiradaJugador);

                        // Bonificador
                        if (tiradaJugador == 1)
                        {
                            Console.WriteLine("¡EXTRA! Puedes cambiar el 1 por un 6.");
                            Console.Write("¿Quieres usarlo? 1) Sí  2) No: ");

                            if (!int.TryParse(Console.ReadLine(), out opcionBonificador))
                            {
                                opcionBonificador = 0;
                            }

                            if (opcionBonificador == 1)
                            {
                                Console.WriteLine("Bonificador utilizado.");
                                tiradaJugador = 6;
                            }
                            else
                            {
                                Console.WriteLine("No has utilizado el bonificador.");
                            }
                        }

                        puntosJugador += tiradaJugador;
                    }
                    else
                    {
                        Console.WriteLine("El jugador está plantado.");
                    }

                    Console.WriteLine();
                    Console.WriteLine("Puntos del jugador: " + puntosJugador);

                    // COMPROBAMOS SI ALGUIEN SE HA PASADO
                    if (puntosJugador > 21)
                    {
                        Console.WriteLine("¡El jugador se ha pasado de 21!");
                        seguimosTirando = false;
                        break;
                    }

                    if (puntosIA > 21)
                    {
                        Console.WriteLine("¡La IA se ha pasado de 21!");
                        seguimosTirando = false;
                        break;
                    }

                    // Comprobamos si alguien ha llegado a 21
                    if (puntosJugador == 21 || puntosIA == 21)
                    {
                        Console.WriteLine("¡Se han alcanzado los 21 puntos!");
                        seguimosTirando = false;
                        break;
                    }

                    // Comportamiento de la IA
                    if (puntosIA > 15 && plantadoIA == false)
                    {
                        Console.WriteLine("La IA está plantada...");
                        plantadoIA = true;
                    }
                    else if (plantadoIA == false)
                    {
                        Console.WriteLine("La IA sigue...");
                    }

                    // Decisión del jugador
                    if (plantadoJugador == false)
                    {
                        bool opcionCorrecta = false;

                        do
                        {
                            Console.Write("¿Sigues o te plantas? 1) Sigues  2) Te plantas: ");

                            if (!int.TryParse(Console.ReadLine(), out opcionTiramos))
                            {
                                opcionTiramos = 0;
                            }

                            if (opcionTiramos == 1)
                            {
                                Console.WriteLine("Siguiente ronda...");
                                opcionCorrecta = true;
                            }
                            else if (opcionTiramos == 2)
                            {
                                Console.WriteLine("Estás plantado...");
                                plantadoJugador = true;
                                opcionCorrecta = true;
                            }
                            else
                            {
                                Console.WriteLine("Opción incorrecta.");
                            }

                        } while (opcionCorrecta == false);
                    }

                    // Si ambos están plantados, termina la partida
                    if (plantadoJugador == true && plantadoIA == true)
                    {
                        Console.WriteLine("Ambos jugadores están plantados.");
                        seguimosTirando = false;
                    }

                    numRonda++;

                } while (seguimosTirando == true);

                iniciamosPartida = false;
            }

            // Resultados finales
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine("Calculando resultados...");
            Console.WriteLine("Puntos de la IA: " + puntosIA);
            Console.WriteLine("Puntos del jugador: " + puntosJugador);
            Console.WriteLine("----------");

            if (puntosJugador > 21 && puntosIA > 21)
            {
                Console.WriteLine("¡Ambos os habéis pasado! Empate.");
            }
            else if (puntosJugador > 21)
            {
                Console.WriteLine("¡Has perdido! Te has pasado de 21.");
            }
            else if (puntosIA > 21)
            {
                Console.WriteLine("¡Has ganado! La IA se ha pasado.");
            }
            else if (puntosJugador > puntosIA)
            {
                Console.WriteLine("¡Has ganado!");
            }
            else if (puntosIA > puntosJugador)
            {
                Console.WriteLine("¡Has perdido!");
            }
            else
            {
                Console.WriteLine("¡Empate!");
            }

            Console.WriteLine("----------");
        }
    }
}
