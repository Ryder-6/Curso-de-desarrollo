using System;

namespace Teoria_y_ejercicios_T3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            ////////////Ejercicio 1/////////
            //contador con WHILE
            //Console.Write("¿Cuantas veces repetimos?:");
            //int i = int.Parse(Console.ReadLine());
            //int x = 0;
            //while (i != x - 1)
            //{
            //    Console.WriteLine("vamos por ella repeticion numero: " + i + " de " + x);
            //    x ++;
            //}


            //Contador con DO WHILE
            //Console.Write("¿Cuantas veces repetimos?:");
            //int i = int.Parse(Console.ReadLine());
            //int x = 0;
            //do
            //{
            //    Console.WriteLine("vamos por ella repeticion numero: " + i + " de " + x);
            //} while (i != x++);


            //Contador con Bucle FOR
            //Console.Write("¿Cuantas veces repetimos?: ");
            //int rep = int.Parse(Console.ReadLine());
            //for (int i = 0; i < rep; i++)
            //{
            //    Console.WriteLine(i);
            //}



            ///////////////Ejercicio 2/////////////
            //Tabla de multiplicar
            //Console.Write("¿Que tabla quieres?: ");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("Cuantas veces?: ");
            //int y = int.Parse(Console.ReadLine());
            //int i = 0;
            //while (i++ != y)
            //{
            //    Console.WriteLine(x * i);
            //}


            ///////////////Ejercicio 3/////////////
            //Tabla de multiplicar con FOR
            Console.Write("¿Que tabla quieres?: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Cuantas veces?: ");
            int y = int.Parse(Console.ReadLine());
            for (int i = 0; i <= y; i++)
            {
                Console.WriteLine(x * i);
            }




        }
    }
}
