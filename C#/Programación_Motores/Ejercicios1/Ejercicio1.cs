//Programacion y motores con Salva
//
//
//
//
//
//
//
//
//  Ejercicios clase 05_10_26
//
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Ejercicio1
    {
        static void Main(string[] args)
        {
            //
            //  Ejercicio1
            //  Calcula S y P del cubo
            //
            Console.WriteLine("Hello, World!");
                        
            int lado = 23;
            int superficie;
            int perimetro;

            superficie = lado * lado;
            perimetro = lado * 4;

            Console.WriteLine("La superficie del cuadrado es: " + superficie + " metros");
            Console.WriteLine("El perimetro del cuadrado es: " + perimetro + " metros");
            //
            //  Ejercicio 2
            //  Calcula tu edad1
            //
            int anyoNacimiento;
            int anyoActual = 2026;
            int edad1;

            Console.Write("Introduce tu año de nacimiento: ");

            anyoNacimiento = Int32.Parse(Console.ReadLine());
            edad1 = anyoActual - anyoNacimiento;

            Console.WriteLine("Tienes " + edad1 + " años");
            //
            //  Ejercicio 3
            //  Divide dos numeros + resultado en decimales
            //
            int numero1,numero2;
            Console.Write("Introduce el primer numero: ");
            numero1 = Int32.Parse(Console.ReadLine());
            Console.Write("Introduce el segundo numero: ");
            numero2 = Int32.Parse(Console.ReadLine());
            float division = numero1 / numero2;
            Console.WriteLine( numero1 + " entre " + numero2 + " es " + division);
            //
            //  Ejericicio 4
            //  comprobacion por if else de edad
            //
            int edad2;
            Console.Write("Inroduce  tu edad: ");
            edad2 = Int32.Parse(Console.ReadLine());
            if (edad2 > 17)
            {
                Console.WriteLine("Eres mayor de edad");
            }
            else
            {
                Console.WriteLine("Eres menor de edad");
            }
        }
    }
}