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
            //Console.Write("¿Que tabla quieres?: ");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("Cuantas veces?: ");
            //int y = int.Parse(Console.ReadLine());
            //for (int i = 0; i <= y; i++)
            //{
            //    Console.WriteLine(x * i);
            //}


            ///////////////////////////DIA 4///////////////////////
            ///////////////Ejercicio 1/////////////
            ////Contador
            //Console.Write("¿Hasta que numero quieres que cuente?: ");
            //int x = int.Parse(Console.ReadLine());
            ////Primer bucle;     WHILE
            //Console.WriteLine("Bucle WHILE: ");
            //int i = 0;
            //while (i++ != x)
            //{
            //    Console.WriteLine(i);
            //}

            ////Segundo bucle;   DO WHILE
            //Console.WriteLine(" ");
            //i = 0;
            //Console.WriteLine("Bucle Do While: "); 
            //do
            //{
            //    Console.WriteLine(i);
            //} while (i++ != x);

            ////Tercer bucle;      FOR
            //Console.WriteLine(" ");
            //Console.WriteLine("Bucle FOR: ");
            //for (i = 0; i <= x; i++)
            //{
            //    Console.WriteLine(i);
            //}


            ///////////////Ejercicio 2/////////////
            //Sumas consecutivas en orden +1 +2 +3 +4 +5 +6...
            Console.Write("¿Hasta que numero quieres que sume?: ");
            int x = int.Parse(Console.ReadLine());
            int res = 0;
            for (int i = 0; i <= x; i++)
            {
                res = i + res;
            }
            Console.WriteLine("Resultado" + res);
        }
    }
}
