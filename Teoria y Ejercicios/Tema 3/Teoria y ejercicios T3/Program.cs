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
            //Console.Write("¿Hasta que numero quieres que sume?: ");
            //int x = int.Parse(Console.ReadLine());
            //int res = 0;
            //for (int i = 0; i <= x; i++)
            //{
            //    res = i + res;
            //} 
            //Console.WriteLine("Resultado" + res);



            ///////////////Ejercicio 3/////////////
            ////Contador invertido
            /*Se crea una variable con el mismo valor que el numero de inicio,
             *con cada bucle a (y) se le resta 1 hasta que el contador (i) llegue al numero 
             * introducido por el usuario*/

            //Console.Write("¿Hasta que numero quieres que cuente?: ");
            //int x = int.Parse(Console.ReadLine());
            ////Primer bucle;     WHILE
            //Console.WriteLine("Bucle WHILE: ");
            //int y = x;
            //int i = 0;
            //while (i != x )
            //{                
            //    Console.WriteLine(y);
            //    y--;
            //    i++;
            //}

            ////Segundo bucle;   DO WHILE
            //Console.WriteLine(" ");
            //y = x;
            //Console.WriteLine("Bucle Do While: ");
            //i = 0;
            //do
            //{
            //    Console.WriteLine(y);
            //    y--;
            //} while (i++ != x);

            ////Tercer bucle;      FOR
            //Console.WriteLine(" ");
            //Console.WriteLine("Bucle FOR: ");
            //for (y = i; y >= 0; y--)
            //{
            //    Console.WriteLine(y);
            //}



            ///////////////Ejercicio 4/////////////
            ////Interfaz con Bucles
            //int i = 0;
            //do
            //{
            //    Console.WriteLine("Opcion:");
            //    Console.WriteLine("1. Refran");
            //    Console.WriteLine("2. Chiste");
            //    Console.WriteLine("3. Insulto");
            //    Console.WriteLine("4. Salir");
            //    i = int.Parse(Console.ReadLine());
            //    switch (i)
            //    {
            //        case 1:
            //            Console.WriteLine("Si la vida te da limones");
            //            break;                    
            //        case 2:
            //            Console.WriteLine("Van dos y se cae ");
            //            break;                    
            //        case 3:
            //            Console.WriteLine("Viejo puto");
            //            break;                   
            //        case 4:
            //            Console.WriteLine("Hasta luego Lucas");
            //            break;
            //        default:
            //            Console.WriteLine("Invalido");
            //            break;
            //    }
            //} while (i != 4); ;

            ///////////////Ejercicio /////////////
            ////Pregunta 10 numeros y muestra la suma de los 10 numeros introducidos
            Console.Write("Cauntas veces quieres repetir el codigo?");
            int repe = int.Parse(Console.ReadLine());
            int res = 0;

            for (int i = 0; i != repe; i++)
            {
                Console.Write("¿Numero a sumar?: ");
                int sum = int.Parse(Console.ReadLine());
             
                    res = res + sum;
            }
            Console.WriteLine("El resultado es: " + res);
        }
    }
}
