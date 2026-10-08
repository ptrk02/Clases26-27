//Programacion y motores con Salva
//
//
//
//
//
//
//  EJERCICIOS 3A: WHILE INICIALES  
//
//  Ejercicios clase 08_10_26
//
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class WhileIniciales
    {
        static void Main(string[] args)
        {
            //
            // Ejercicio 1
            // Haz un algoritmo que muestre 5 veces el mensaje de bienvenida de un NPC: "Bienvenido, aventurero."
            //

            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("Bienvenido, aventurero.");
                i++;
            }

            //
            // Ejercicio 2
            // Haz un algoritmo que pida al usuario un número y que muestre ese número de veces el mensaje de bienvenida del NPC: "Bienvenido, aventurero." 
            //

            int numero;
            Console.WriteLine("Introduce un número:");
            numero = Convert.ToInt32(Console.ReadLine());

            int f = 0;
            while (f < numero)
            {
                Console.WriteLine("Bienvenido, aventurero.");
                f++;
            }

            //
            // Ejercicio 3
            // Haz un algoritmo que muestre la cuenta atrás para el inicio de una partida, desde 5.
            //

            int cuentaAtras = 5;
            while (cuentaAtras > 0)
            {
                Console.WriteLine(cuentaAtras);
                cuentaAtras--;
            }

            //
            // Ejercicio 4
            // Haz un algoritmo que pida al usuario un número y que muestre la cuenta atrás para el inicio de la partida desde ese número. 
            //

            Console.WriteLine("Introduce un número para la cuenta atrás:");
            cuentaAtras = Convert.ToInt32(Console.ReadLine());

            while (cuentaAtras > 0)
            {
                Console.WriteLine(cuentaAtras);
                cuentaAtras--;
            }

            if (cuentaAtras == 0)
            {
                Console.WriteLine("¡Comienza la partida!");
            }

            //
            // Ejercicio 5
            // Haz un algoritmo que pida al usuario dos números, que representan la oleada inicial y la oleada final de enemigos (el 1º número siempre será menor que el 2º), y que muestre la cuenta desde la primera oleada hasta la última. 
            //

            int oleadaInicial, oleadaFinal;

            Console.WriteLine("Introduce la oleada inicial:");
            oleadaInicial = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce la oleada final:");
            oleadaFinal = Convert.ToInt32(Console.ReadLine());

            while (oleadaInicial <= oleadaFinal)
            {
                Console.WriteLine(oleadaInicial);
                oleadaInicial++;
            }

            //
            // Ejercicio 6
            // Haz un algoritmo que pida al usuario dos números de oleada y que muestre la cuenta desde la oleada menor a la mayor. 
            //

            int oleada1, oleada2;
            Console.Write("Introduce la primera oleada:");
            oleada1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce la segunda oleada:");
            oleada2 = Convert.ToInt32(Console.ReadLine());
            
            if (oleada1 > oleada2)
            {
                int temp = oleada1;
                oleada1 = oleada2;
                oleada2 = temp;
            }
            else if (oleada1 == oleada2)
            {
                Console.WriteLine("Las oleadas son iguales.");
            }
            while (oleada1 <= oleada2)
            {
                Console.WriteLine(oleada1);
                oleada1++;
            }

            //
            // Ejercicio 7
            // Haz un algoritmo que muestre la tabla de puntos por combo x5 (la tabla de multiplicar del 5).
            //

            int tabla = 1;
            int multiplicador = 5;
            while (tabla <= 10)
            {
                Console.WriteLine(tabla * multiplicador);
                tabla++;
            }

            //
            // Ejercicio 8
            // Haz un algoritmo que le pida al usuario un número y muestre la tabla de puntos por combo correspondiente a ese número. 
            //

            Console.WriteLine("Introduce un número para mostrar su tabla de multiplicar:");
            int numeroTabla = Convert.ToInt32(Console.ReadLine());
            tabla = 1;
            while (tabla <= 10)
            {
                Console.WriteLine(tabla * numeroTabla);
                tabla++;
            }

        }
    }
}
