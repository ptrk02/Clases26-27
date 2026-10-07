//Programacion y motores con Salva
//
//
//
//
//
//
//  EJERCICIOS 0: CONDICIONES 
//
//  Ejercicios clase 07_10_26
//
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Condiciones
    {
        static void Main(string[] args)
        {
            //
            // Ejercicio 1
            // Un jugador termina una mazmorra y consigue una cantidad de oro. Ingresar el oro obtenido por el jugador; si supera los 1200 de oro, mostrar un mensaje en pantalla indicando que debe pagar un impuesto al Tesoro del Reino. 
            //

            float cantidadOro;

            Console.Write("Introduce la cantidad de oro: ");
            cantidadOro = Int32.Parse(Console.ReadLine());

            if(cantidadOro >= 1200)
            {
                Console.WriteLine("Debes pagar impuesto al Tesoro del Reino.");
            }
            else
            {
                Console.WriteLine("No debes pagar impuesto al Tesoro del Reino.");
            }

            //
            // Ejericio 2
            // Realizar un programa que lea por teclado el daño de dos armas distintas. Si el daño de la primera arma es mayor al de la segunda, informar la suma y la diferencia de daño entre ambas; en caso contrario, informar el producto y la división del daño de la primera respecto a la segunda.
            //

            float arma1;
            float arma2;
            
            Console.Write("Daño arma 1: ");
            arma1 = Int32.Parse(Console.ReadLine());
            Console.Write("Daño arma 2: ");
            arma2 = Int32.Parse(Console.ReadLine());

            if( arma1 >= arma2)
            {
                float sumaDamage = arma1 + arma2;
                float difDamage = arma1 - arma2;

                Console.WriteLine("La suma del daño es: " + sumaDamage);
                Console.WriteLine("La diferencia del daño es: " + difDamage);
            }
            else
            {
                float prodDamage = arma1 * arma2;
                float divDamage = arma2 / arma2;

                Console.WriteLine("El producto del daño es: " + prodDamage);
                Console.WriteLine("La division del daño es: " + divDamage);
            }

            //
            // Ejericio 3
            // Se ingresan las puntuaciones obtenidas por un jugador en tres desafíos de un mismo nivel. Si el promedio de las tres puntuaciones es mayor o igual a cinco, mostrar un mensaje "Nivel superado".
            //

            float nota1, nota2, nota3;

            Console.Write("Primera nota: ");
            nota1 = Int32.Parse(Console.ReadLine());
            Console.Write("Segunda nota: ");
            nota2 = Int32.Parse(Console.ReadLine());
            Console.Write("Tercera nota: ");
            nota3 = Int32.Parse(Console.ReadLine());

            float sumaNotas = nota1 + nota2 + nota3;
            float mediaNotas = sumaNotas/3;

            if(mediaNotas >= 5)
            {
                Console.WriteLine("Nivel superado.");
            }
            else
            {
                Console.WriteLine("Nivel no superado.");
            }

            //
            // Ejericio 4
            // Se ingresa por teclado el nivel de experiencia de un personaje, un número positivo de uno o dos dígitos (1..99). Mostrar un mensaje indicando si el nivel tiene uno o dos dígitos. 
            //

            float experiencia;
            
            Console.Write("Experiencia: ");
            experiencia = Int32.Parse(Console.ReadLine());


            if(experiencia > 9)
            {
                Console.Write("El nivel tiene dos dígitos");
            }
            else
            {
                Console.Write("El nivel tiene un dígito");
            }

        }
    }
}