//Programacion y motores con Salva
//
//
//
//
//
//
//  EJERCICIOS 4: BUCLE FOR
//
//  Ejercicios clase 15_10_26
//
using System;
using System.Runtime.Versioning;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class BucleFor
    {
        static void Main(string[] args)
        {
        //     //
        //     // Ejercicio 1
        //     // Desarrollar un programa que solicite la carga de 10 números e imprima la suma de los últimos 5 valores ingresados.
        //     //
        //     Console.WriteLine();
        //     Console.WriteLine("Ejercicio 1");

        //     Console.WriteLine("Dime 10 numeros y te calculo la suma de los últimos 5 valores ingresados.");
        //     int numerosVeces = 10, numeroTotal = 0, numeroTemporal;

        //     for(int i = 0; i < numerosVeces; i++)
        //     {
        //         Console.Write("Dime el numero:   ");
        //         numeroTemporal = int.Parse(Console.ReadLine() ?? "0");

        //         if(i >= 5)
        //         {
        //             numeroTotal = numeroTotal + numeroTemporal;
        //         }
        //    }
        //    Console.WriteLine("La suma de los últimos 5 valores ingresados es: " + numeroTotal);

        //     //
        //     // Ejercicio 2
        //     // Realizar un programa que lea los lados de n triángulos, e informar: a) De cada uno de ellos, qué tipo de triángulo es: equilátero (tres lados iguales), isósceles (dos lados iguales), o escaleno (ningún lado igual) b) Cantidad de triángulos de cada tipo. c) Tipo de triángulo que posee menor cantidad.
        //     //
        //     Console.WriteLine();
        //     Console.WriteLine("Ejercicio 2");

        //     Console.Write("Cuanto triangulos quieres que calcule: ");
        //     int cantidadTriangulos = int.Parse(Console.ReadLine() ?? "0");

        //     for(int i = 0; i < cantidadTriangulos; i++)
        //     {
        //             Console.Write("Cuanto miden los lados del " + (cantidadTriangulos - i) + "º triangulo:   ");
        //             Console.Write("Lado 1: ");
        //             int lado1 = int.Parse(Console.ReadLine() ?? "0");
        //             Console.Write("Lado 2: ");
        //             int lado2 = int.Parse(Console.ReadLine() ?? "0");
        //             Console.Write("Lado 3: ");
        //             int lado3 = int.Parse(Console.ReadLine() ?? "0");

        //             if(lado1 == lado2 && lado1== lado3 && lado2 == lado3)
        //             {
        //                 Console.WriteLine("Este triangulo es equilátero (tres lados iguales) ");
        //             }
        //             else if(lado1 != lado2 && lado1 != lado3 && lado2 != lado3)
        //             {
        //                 Console.WriteLine("Este triangulo es escaleno (ningún lado igual) ");
        //             }
        //             else
        //             {
        //                 Console.WriteLine("Este triangulo es isósceles (dos lados iguales) ");
        //             }

        //             if(lado1 < lado2 && lado1 < lado3)
        //             {
        //                 Console.WriteLine("El primer lado es el más pequeño.");
        //             }
        //             else if(lado2 < lado1 && lado2 < lado3)
        //             {
        //                 Console.WriteLine("El segundo lado es el más pequeño.");
        //             }
        //             else
        //             {
        //                 Console.WriteLine("El tercer lado es el más pequeño.");
        //             }
        //     }

            //
            // Ejercicio 3
            // Escribir un programa que pida ingresar coordenadas (x,y) que representan puntos en el plano. Informar cuántos puntos se han ingresado en el primer, segundo, tercer y cuarto cuadrante. Al comenzar el programa se pide que se ingrese la cantidad de puntos a procesar.
            //
            Console.WriteLine();
            Console.WriteLine("Ejercicio 3");

            float x,y;
            int cuadrante1 = 0,cuadrante2 = 0,cuadrante3 = 0,cuadrante4 = 0;

            Console.Write("Cuantos vectores quieres que calcule y te dire en que cuadrante están: ");
            int vectores = int.Parse(Console.ReadLine() ?? "0");

            for(int i = 0; i < vectores; i++)
            {
                Console.WriteLine("Datos del vector " + (vectores - i) );
                Console.Write("Coordenada x del vector " + (vectores - i) + ": ");
                x = float.Parse(Console.ReadLine() ?? "0");
                Console.Write("Coordenada y del vector " + (vectores - i) + ": ");
                y = float.Parse(Console.ReadLine() ?? "0");

                if(x > 0 && y > 0)
                {
                    cuadrante1++;
                }
                else if(x < 0 && y > 0)
                {
                    cuadrante2++;
                }
                else if(x > 0 && y < 0)
                {
                    cuadrante3++;
                }
                else if( x < 0 && y < 0)
                {
                    cuadrante4++;
                }
                else
                {
                    Console.WriteLine("Coordenada en ningun cuadrante.");
                }
            }

            Console.WriteLine("--- " + cuadrante1 + " vectores estan en el primer cuadrante.");
            Console.WriteLine("--- " + cuadrante2 + " vectores estan en el segundo cuadrante.");
            Console.WriteLine("--- " + cuadrante3 + " vectores estan en el tercero cuadrante.");
            Console.WriteLine("--- " + cuadrante4 + " vectores estan en el cuarto cuadrante.");
           

            //
            // Ejercicio 4
            // Se realiza la carga de 6 valores enteros por teclado. Se desea conocer: a) La cantidad de valores ingresados negativos. b) La cantidad de valores ingresados positivos. c) La cantidad de múltiplos de 15. d) El valor acumulado de los números ingresados que son pares. 
            //
            Console.WriteLine();
            Console.WriteLine("Ejercicio 4");

            Console.WriteLine("Pon 6 valores enteros por teclado");
            int veces = 6, numsNegativos = 0, numsPositivos = 0, numsMultiplesDe15 = 0, numTotalesPares = 0;

            for (int i = 0; i < veces; i++)
            {
                Console.Write("Valor: ");
                int valor = int.Parse(Console.ReadLine() ?? "0");

                if (valor < 0)
                {
                    numsNegativos = numsNegativos++;
                }
                else if (valor > 0)
                {
                    numsPositivos = numsPositivos++;
                }
                else if (valor % 15 == 0)
                {
                    numsMultiplesDe15 = numsMultiplesDe15++;
                }
                else if (valor % 2 == 0)
                {
                    numTotalesPares = valor + numTotalesPares;
                }
            }
            Console.WriteLine("La cantidad de valores ingresados negativos: " + numsNegativos);
            Console.WriteLine("La cantidad de valores ingresados positivos: " + numsPositivos);
            Console.WriteLine("La cantidad de múltiplos de 15: " + numsMultiplesDe15);
            Console.WriteLine("El valor acumulado de los números ingresados que son pares: " + numTotalesPares);


            //
            // Ejercicio 5
            // Escribe un programa que pida un número e informe si el número es primo. Resuélvelo con el operador resto (%). Ten en cuenta que un número es primo si y sólo si es divisible por 1 y por sí mismo. Es decir, que el resultado de la división por cualquier otro número debería tener decimales.
            //
            Console.WriteLine();
            Console.WriteLine("Ejercicio 5");

            Console.WriteLine("Escribe un número y te dire si es o no primo");
            Console.Write("Número: ");
            int numero = int.Parse(Console.ReadLine() ?? "0");
           
                if (numero % numero == 0 && numero % 1 == 0)
                {
                    Console.WriteLine("Si es primo");
                }
                else
                {
                    Console.WriteLine("No es primo");
                }

            //
            // Ejercicio 6
            // Escribe un programa que pida un número (ej.: 2) y su potencia (ej.: 3), e informe del cálculo.
            //
            Console.WriteLine();
            Console.WriteLine("Ejercicio 6");

            Console.Write("Dime un número para calcular su potencia: ");
            int number = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Dime la potencia a la que elevare el número: ");
            int power = int.Parse(Console.ReadLine() ?? "0");

            for(int i = 1; i <= power; i++)
            {
                number = number * number;
            }

            //int answer = (int)Math.Pow(number, power);
            Console.WriteLine("El total es: " + number);
        }
    }
}