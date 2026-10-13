//Programacion y motores con Salva
//
//
//
//
//
//
//  EJERCICIOS 2: CONDICIONES CON OPERADORES LÓGICOS 
//
//  Ejercicios clase 13_10_26
//
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class CondicionesConOperadoresLogicos
    {
        static void Main(string[] args)
        {
            //
            // Ejercicio 1
            // Se carga la fecha de inicio de un evento especial del juego (día, mes y año) por teclado. Mostrar un mensaje si el evento cae dentro del primer trimestre del año (enero, febrero o marzo). Cargar por teclado el valor numérico del día, mes y año. 
            //
            Console.WriteLine("Ejericicio 1");

            Console.Write("Ingrese el día: ");
            int dia = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Ingrese el mes: ");
            int mes = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Ingrese el año: ");
            int año = int.Parse(Console.ReadLine() ?? "0");

            if (mes == 1 || mes == 2 || mes == 3)
            {
                Console.WriteLine("El evento cae dentro del primer trimestre del año.");
            }
            else
            {
                Console.WriteLine("El evento no cae dentro del primer trimestre del año.");
            }

            //
            // Ejercicio 2
            // Confeccionar un programa que lea por teclado los puntos de vida de tres enemigos distintos y muestre cuál de ellos tiene más vida (el enemigo más fuerte). 
            //
            Console.WriteLine("Ejericicio 2");

            int vidaEnemigo1, vidaEnemigo2, vidaEnemigo3;

            Console.Write("Vida del enemigo1 :");
            vidaEnemigo1 = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Vida del enemigo2 :");
            vidaEnemigo2 = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Vida del enemigo3 :");
            vidaEnemigo3 = int.Parse(Console.ReadLine() ?? "0");

            if (vidaEnemigo1 > vidaEnemigo2 && vidaEnemigo1 > vidaEnemigo3)
            {
                Console.WriteLine("El enemigo 1 es el más fuerte con " + vidaEnemigo1 + " puntos de vida.");
            }
            else if (vidaEnemigo2 > vidaEnemigo1 && vidaEnemigo2 > vidaEnemigo3)
            {
                Console.WriteLine("El enemigo 2 es el más fuerte con " + vidaEnemigo2 + " puntos de vida.");
            }
            else if (vidaEnemigo3 > vidaEnemigo1 && vidaEnemigo3 > vidaEnemigo2)
            {
                Console.WriteLine("El enemigo 3 es el más fuerte con " + vidaEnemigo3 + " puntos de vida.");
            }
            else
            {
                Console.WriteLine("Hay un empate entre los enemigos.");
            }

            //
            // Ejercicio 3
            // Se ingresan por teclado los valores de tres cristales de poder recogidos por el jugador. Si los tres valores son iguales, calcular la suma del primero con el segundo y multiplicar ese resultado por el tercero, mostrando el bono total obtenido.
            //
            Console.WriteLine("Ejericicio 3");

            int cristal1, cristal2, cristal3;
            
            Console.Write("Valor del cristal1 : ");
            cristal1 = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Valor del cristal2 : ");
            cristal2 = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Valor del cristal3 : ");
            cristal3 = int.Parse(Console.ReadLine() ?? "0");

            if (cristal1 == cristal2 && cristal2 == cristal3)
            {
                int bonoTotal = (cristal1 + cristal2) * cristal3;
                Console.WriteLine("Bono total obtenido: " + bonoTotal);
            }
            else
            {
                Console.WriteLine("Los cristales no son iguales, no se puede calcular el bono.");
            }


            //
            // Ejercicio 4
            // Se ingresan por teclado los niveles de tres objetos del inventario. Si al menos uno de los objetos tiene un nivel menor a 10, mostrar en pantalla el mensaje "Alguno de los objetos es de nivel bajo". 
            //
            Console.WriteLine("Ejericicio 4");

            int objeto1, objeto2, objeto3;
            
            Console.Write("Valor del cristal1 : ");
            objeto1 = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Valor del cristal2 : ");
            objeto2 = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Valor del cristal3 : ");
            objeto3 = int.Parse(Console.ReadLine() ?? "0");

            if (objeto1 < 10 || objeto2 < 10 || objeto3 < 10)
            {
                Console.WriteLine("Alguno de los objetos es de nivel bajo.");
            }

            //
            // Ejercicio 5
            // Escribir un programa que pida ingresar la posición de un personaje en el mapa del juego, es decir dos valores enteros x e y (distintos de cero). Posteriormente, mostrar en pantalla en qué cuadrante del mapa se encuentra dicho personaje (1er Cuadrante si x > 0 Y y > 0, 2do Cuadrante: x < 0 Y y > 0, etc.). 
            //
            Console.WriteLine("Ejericicio 5");

            int posX,posY;
            int cuadrante = 0;

            Console.Write("Ingresa cordenada del mapa x: ");
            posX = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Ingresa cordenada del mapa x: ");
            posY = int.Parse(Console.ReadLine() ?? "0");
            
            if(posX != 0 || posY != 0)
            {
                Console.Write("Ingresa cordenada del mapa x: ");
                posX = int.Parse(Console.ReadLine() ?? "0");
                Console.Write("Ingresa cordenada del mapa x: ");
                posY = int.Parse(Console.ReadLine() ?? "0");
            }

            if(posX >= 1 && posY >= 1)
            {
                cuadrante = 1;
            }
            else if(posX <= 0 && posY >= 1)
            {
                cuadrante = 2;
            }
            else if(posX >= 1 && posY <= 0)
            {
                cuadrante = 3;
            }
            else if(posX <= 0 && posY <= 0)
            {
                cuadrante = 4;
            }

            Console.WriteLine("El personase se encuentra en el cuadrante " + cuadrante);

            //
            // Ejercicio 6
            // De un jugador se conoce el oro ganado en su última partida y su antigüedad en el juego (cantidad de partidas jugadas). Se pide confeccionar un programa que lea los datos de entrada e informe: a) Si el oro ganado es inferior a 500 y su antigüedad es igual o superior a 10 partidas, otorgarle una bonificación del 20%, mostrando el oro final a recibir. b) Si el oro ganado es inferior a 500 pero su antigüedad es menor a 10 partidas, otorgarle una bonificación del 5%. c) Si el oro ganado es mayor o igual a 500, mostrar el oro en pantalla sin cambios.
            //
            Console.WriteLine("Ejericicio 6");

            int oro, antiguedad;

            Console.Write("Cuanto oro tienes? ");
            oro = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Cuantas partidas has jugado? ");
            antiguedad = int.Parse(Console.ReadLine() ?? "0");

            //
            // Ejercicio 7
            // Escribir un programa en el cual, dada una lista de tres valores de daño distintos infligidos por un jugador, se calcule e informe su rango de variación (debe mostrar el mayor y el menor de ellos). 
            //
            Console.WriteLine("Ejericicio 7");

            int damage1,damage2,damage3;

            Console.Write("Primer daño inflingido: ");
            damage1 = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Segundo daño inflingido: ");
            damage2 = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Tercer daño inflingido: ");
            damage3 = int.Parse(Console.ReadLine() ?? "0");

            if(damage1 >= damage2 && damage1 >= damage3)
            {
                Console.Write("El primer golpe es el más fuerte");
            }
            else if(damage2 >= damage1 && damage2 >= damage3)
            {
                Console.Write("El segundo golpe es el más fuerte");
            }
            else
            {
                Console.Write("El tercer golpe es el más fuerte");
            }
            
            if(damage1 <= damage2 && damage1 <= damage3)
            {
                Console.Write("El primer golpe es el más flojo");
            }
            else if(damage2 <= damage1 && damage2 <= damage3)
            {
                Console.Write("El segundo golpe es el más flojo");
            }
            else
            {
                Console.Write("El tercer golpe es el más flojo");
            }
            //
            // Ejercicio 8
            // Se ingresa por teclado la variación de vida de un personaje tras un combate (un número entero). Mostrar una leyenda que indique si la variación es positiva (recuperó vida), nula (sin cambios) o negativa (recibió daño). 
            //
            Console.WriteLine("Ejericicio 8");

            //
            // Ejercicio 9
            // Debemos calcular el éxito del jugador en un nivel de nuestro juego: cantidad total de objetivos que contiene el nivel, junto a la cantidad de objetivos que el jugador completó realmente. Se pide confeccionar un programa que ingrese los dos datos por teclado e informe del éxito del jugador, según el porcentaje de objetivos completados, y sabiendo que: Nivel superado (✩✩✩):	Porcentaje>=90%. Nivel superado (✩✩):		Porcentaje>=75% y <90%. Nivel superado (✩):		Porcentaje>=50% y <75%. Nivel no superado:		Porcentaje<50%.
            //
            Console.WriteLine("Ejericicio 9");
        }
    }
}