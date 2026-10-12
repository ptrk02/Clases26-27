//Programacion y motores con Salva
//
//
//
//
//
//
//  EJERCICIOS 3B: WHILE 
//
//  Ejercicios clase _10_26
//
using System;

namespace Ejercicios4 // Note: actual namespace depends on the project name.
{
    internal class While
    {
        static void Main(string[] args)
        {
            //
            // Ejercicio 1
            // Escribir un programa que solicite ingresar las puntuaciones obtenidas en 10 misiones de un juego y nos informe cuántas misiones tienen puntuación mayor o igual a 7 y cuántas menores. 
            //
            int partidas = 1;
            int puntuacion;
            int contMayor = 0, contMenor = 0;

            for(partidas = 0; partidas < 10; partidas++)
            {
                Console.Write("Puntuación de la partida " + partidas);
                puntuacion = Int32.Parse(Console.ReadLine());

                if(puntuacion >= 7)
                {
                    contMayor++;
                }
                else
                {
                    contMenor++;
                }
            }
            Console.Write(contMayor + " puntuaciones son mayores o iguales a 7");
            Console.Write(contMenor + " puntuaciones son menores a 7");


            //
            // Ejercicio 2
            // Se ingresan por teclado n valores de resistencia (armadura) de distintos personajes. Mostrar la resistencia promedio de los personajes.
            //
            int resistencia, personajes = 0, resistenciaTotal = 0;
            int resisPromedio;

            Console.Write("Ingrese la cantidad de personajes: ");
            personajes = Int32.Parse(Console.ReadLine());

            for(int i = 0; i < personajes; i++)
            {
                Console.Write("Ingrese la resistencia del personaje " + (i + 1) + ": ");
                resistencia = Int32.Parse(Console.ReadLine());
                resistenciaTotal += resistencia;
            }
            resisPromedio = resistenciaTotal / personajes;

            Console.WriteLine("La resistencia promedio de los personajes es: " + resisPromedio);

            //
            // Ejercicio 3
            // En una taberna de aventureros trabajan X NPCs cuyas recompensas oscilan entre 100 y 500 monedas de oro. Realizar un programa que lea la recompensa de cada NPC e informe cuántos reciben entre 100 y 300 monedas y cuántos reciben más de 300 monedas. Además, el programa deberá informar el total de oro repartido entre todos los NPC. 
            //

            int recompensa, npc = 0, totalOro = 0;
            int contEntre100y300 = 0, contMayor300 = 0;

            Console.Write("Ingrese la cantidad de NPCs: ");
            npc = Int32.Parse(Console.ReadLine());

            for(int i = 0; i < npc; i++)
            {
                Console.Write("Ingrese la recompensa del NPC " + (i + 1) + ": ");
                recompensa = Int32.Parse(Console.ReadLine());
                totalOro += recompensa;

                if(recompensa >= 100 && recompensa <= 300)
                {
                    contEntre100y300++;
                }
                else if(recompensa > 300)
                {
                    contMayor300++;
                }
            }
            Console.WriteLine("Cantidad de NPCs con recompensa entre 100 y 300: " + contEntre100y300);
            Console.WriteLine("Cantidad de NPCs con recompensa mayor a 300: " + contMayor300);
            Console.WriteLine("Total de oro repartido entre todos los NPCs: " + totalOro);

            //
            // Ejercicio 4
            // Realizar un programa que imprima los 25 primeros valores de la serie de puntos otorgados por oleada: 11 - 22 - 33 - 44, etc. (No se ingresan valores por teclado.) 
            //

            for(int i = 1; i <= 25; i++)
            {
                Console.WriteLine(i * 11);
            }

            //
            // Ejercicio 5
            // En el juego existen dos sistemas de recompensa: el sistema de racha otorga puntos en cada múltiplo de 8 (hasta llegar a 500), y el sistema de oleada otorga puntos según la serie 11 - 22 - 33 - 44, etc. (25 términos, ejercicio anterior). Mostrar en pantalla ambas secuencias: a) RESUÉLVELO CON 2 BUCLES: cada secuencia se muestra por separado, cada una con su propio bucle. b) RESUÉLVELO CON UN SOLO BUCLE: mostrando ambas secuencias intercaladas y ordenadas. 
            //

            int racha = 8;
            int oleada = 11;

            Console.WriteLine("Secuencia de racha:");
            for(int i = 1; i <= 62; i++)
            {
                Console.WriteLine(i * racha);
            }

            Console.WriteLine("Secuencia de oleada:");
            for(int i = 1; i <= 25; i++)
            {
                Console.WriteLine(i * oleada);
            }


            //
            // Ejercicio 6
            // Realizar un programa que permita cargar los puntos de daño de dos equipos de 15 jugadores cada uno. Informar con un mensaje cuál de los dos equipos causó un daño total acumulado mayor (mensajes "Equipo 1 mayor", "Equipo 2 mayor", "Equipos iguales"). Ten en cuenta que puede haber dos o más estructuras repetitivas en un mismo algoritmo.
            //

            //
            // Ejercicio 7
            // Desarrollar un programa que permita cargar X monedas recogidas por el jugador (valores enteros) y luego informe cuántas tienen un valor par y cuántas impar. Emplear el operador "%" en la condición de la estructura condicional: if (valor % 2 == 0) //Si el if da verdadero, el valor es par.
            //
            
        }
    }
}