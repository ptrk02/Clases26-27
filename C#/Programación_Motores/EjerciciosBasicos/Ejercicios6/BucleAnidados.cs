//Programacion y motores con Salva
//
//
//
//
//
//
//  EJERCICIOS 3C: BUCLE ANIDADOS
//
//  Ejercicios clase 13_10_26
//
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class BucleAnidados
    {
        static void Main(string[] args)
        {
            //
            // Ejercicio 1
            // Imprimir por pantalla una pirámide de asteriscos (resuélvelo con dos bucles) desde 1 hasta 6. 
            //

            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(); // Salto de línea después de cada fila
            }

            //
            // Ejercicio 2
            // Imprimir por pantalla las 10 tablas de multiplicar.
            //

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Tabla del {i}:");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
                Console.WriteLine(); // Línea en blanco entre tablas
            }

            

        }
    }
}