using System;
using System.Collections.Generic;

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


            ///////////////Ejercicio 5/////////////
            ////Pregunta repeticiones de la suma y despues pregunta tantos numeros como repeticiones y los suma todos
            //Console.Write("Cauntas veces quieres repetir el codigo?");
            //int repe = int.Parse(Console.ReadLine());
            //int res = 0;

            //for (int i = 0; i != repe; i++)
            //{
            //    Console.Write("¿Numero a sumar?: ");
            //    int sum = int.Parse(Console.ReadLine());

            //        res = res + sum;
            //}
            //Console.WriteLine("El resultado es: " + res);



            ///////////////Ejercicio 6/////////////
            //ejercicio de 
            //Console.Write("¿Cuantos espacios necesitas?: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] sum = new int[n];       //Creo el ARRAY tipo INT
            //int res = 0; 
            //Console.WriteLine("Introduce tus numeros: ");
            //for (int i = 0; i != n; i++) //Bucle para introducir los datos dentro del ARRAY
            //{
            //    int x = int.Parse(Console.ReadLine()); //Variable que camabia en cada reinicio de bucle al introducir los datos
            //    sum[i] = x;
            //}

            //for (int i = 0; i != n; i++) //Bucle que hace la suma. con cada reinicio se suma 1 al contador, el contador es el que azanza dentro de las casillas del Array
            //{           
            //    res += sum[i];
            //}
            //Console.WriteLine("El resultado es: " + res);

            ///////////////Ejercicio 7/////////////
            //Copiar datos de un array a otro
            //Console.Write("¿Cuantos espacios necesitas?: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] Arr1 = new int[n];
            //int[] Arr2 = new int[n];
            //Console.WriteLine("Introduce tus numeros: ");
            //for (int i = 0; i != n; i++) //
            //{
            //    int x = int.Parse(Console.ReadLine()); //
            //    Arr1[i] = x;
            //}

            //for (int i = 0; i != n; i++) //
            //{
            //    int res = 0;
            //    Arr2[i] = res + Arr1[i];
            //Console.WriteLine("El resultado es: " + Arr2[i]);
            //}           



            ///////////////////Dia5////////////////////

            ///////////////Ejercicio 1/////////////
            //pasar de una casilla a otra
            //int x = 5;
            //int y = 7;
            //int sav = x;

            //y = x;
            //sav = y;


            //////////////Ejercicio 2///////////////
            //Bucle anidado para ordenar de mayor a menor 
            {     /* Teoria:
             i= 0  
             j = i + 1 ( J siempre sera mayor que 1)
              
             i < n; (n es el numero de casillas)
             j < n;
             */

                //int[] numeros = new int[] { 3, 2, 1 };
                //for (int i = 0; i < numeros.Length; i++) /**/
                //{
                //    for (int j = i; j < numeros.Length; j++)/*El segundo bucle se reinicia cada vez que termina
                //            e inicia el bucle principal de nuevo*/
                //    {
                //        if (numeros[j] < numeros[i])
                //        { /* i es el ancla y j recorre todas las casillas, moviendolas una a la izquierda
                //            hasta que ninguno de las casillas de la dereca (a partir de la primera) es menor
                //            a la primera casilla

                //             */
                //            int aux = numeros[i];
                //            numeros[i] = numeros[j];
                //            numeros[j] = aux;
                //        }

                //            /* cuando el mas pequeño es el de la izquierda (i) se suma uno, pasandose a la siguiente casilla
                //             * repitiendo el proceso hasta que todos estan ordenados*/
                //    }
                //    Console.WriteLine( "Resultado: " + numeros[i]);
                //}
            }



            //////////////Ejercicio 3///////////////
            //Piramide de  (*)
            {   //Console.Write("Cauntas veces quieres repetir el codigo?");
                //int repe = int.Parse(Console.ReadLine());
                //String[] arr = new string[repe];
                //for (int i = 0; i < repe; i++) 
                //{
                //    for (int j = 0; j < i; j++)
                //    {
                //        Console.Write("* ");
                //    }
                //    Console.WriteLine("");; 
                //}
            }

            //////////////Ejercicio 3///////////////
            //comprueba si hay alguno repetido
            {   //Console.Write("numero de numeros?");
                //int n = int.Parse(Console.ReadLine());
                //int[] numeros = new int[n];
                //for (int i = 0; i != n; i++) //Bucle para introducir los datos dentro del ARRAY
                //{
                //    int x = int.Parse(Console.ReadLine()); 
                //    numeros[i] = x;
                //}
                //for (int i = 0; i < numeros.Length; i++) /**/
                //{
                //    for (int j = i+1; j < numeros.Length; j++)
                //    {
                //        if (numeros[j] == numeros[i])
                //        {
                //            Console.WriteLine("Hay un numero duplicado: " + numeros[i]);
                //        }
                //    }
                //}


                //PROFESOR
                ////Console.Write("numero de numeros?");
                ////int n = int.Parse(Console.ReadLine());
                ////int[] numeros = new int[n];
                ////bool repe = false;
                ////for (int i = 0; i < numeros.Length && !repe; i++) /**/
                ////{
                ////    for (int j = i + 1; j < numeros.Length && !repe; j++)
                ////    {
                ////        for (int t = 0; t != n ; t++) //Bucle para introducir los datos dentro del ARRAY
                ////        {
                ////            int x = int.Parse(Console.ReadLine());
                ////            numeros[t] = x;

                ////            if (numeros[j] == numeros[i] )
                ////            {
                ////                Console.WriteLine("Hay un numero duplicado: " + numeros[i]);
                ////                repe = true;
                ////            }
                ////        }
                ////    }
                ////}
            }


            ///////////////Ejercicio 4//////////////
            //Que muestre el numero mayor y menor
            {//int[] numeros = new int[] { 3, 2, 1 };
             //for (int i = 0; i < numeros.Length; i++) 
             //{
             //    for (int j = i; j < numeros.Length; j++)
             //    {
             //        if (numeros[j] < numeros[i])
             //        { 
             //            int aux = numeros[i];
             //            numeros[i] = numeros[j];
             //            numeros[j] = aux;
             //        }
             //    }
             //}
             //Console.WriteLine("Resultado: " + numeros[0] + " y " + numeros[2]);  

                ////PROFESOR
                //int[] numeros = new int[] { 3, 2, 1 };
                //int max = int.MaxValue;
                //int min = int.MinValue;
                //for (int i = 0; i < numeros.Length; i++)
                //{
                //    if (numeros[i] > max)
                //    {
                //        max = numeros[i];
                //    }
                //    if (numeros[i] < min)
                //    {
                //        min = numeros[i];
                //    }

                //}
                //Console.WriteLine("Resultado: " + min + " y " + max);
            }

            ///////////////Ejercicio 5//////////////
            //mostrar los parees y los impares
            {            //int[] numeros = new int[] { 3, 2, 1, 4 };
                         //for (int i = 0; i < numeros.Length; i++)
                         //{
                         //    if (numeros[i] % 2 == 0)
                         //    {
                         //        Console.WriteLine("Par " + numeros[i]);

                //    }
                //    if (numeros[i] % 2 != 0)
                //    {
                //        Console.WriteLine("impar " + numeros[i]);
                //    }
                //}
            }


            //////////////Ejercicio 6///////////////
            //Piramide de(numeros)
            {    //Console.Write("Cauntas veces quieres repetir el codigo?");
                 //int num = 1;
                 //int repe = int.Parse(Console.ReadLine());
                 //String[] arr = new string[repe];
                 //for (int i = 0; i < repe; i++)
                 //{
                 //    for (int j = 0; j < i; j++)
                 //    { 
                 //        Console.Write(i);

                //    }         
                //    Console.WriteLine("");

                //}
                //Console.WriteLine("");
                //for (int i = 0; i < repe; i++)
                //{
                //    for (int j = 0; j < i; j++)
                //    {
                //        Console.Write(num + " ");
                //        num++;

                //    }
                //    Console.WriteLine("");
                //}

                //Console.WriteLine("");
                //for (int i = 0; i < repe; i++)
                //{
                //num = 1;

                //    for (int j = 0; j < i; j++)
                //    {
                //        Console.Write(num);
                //        num++;
                //    }
                //    Console.WriteLine("");
                //}
            }



            //////////////Ejercicio 6///////////////
            //
            {
                //Console.WriteLine("Numero de filas y columnas que quieres?");
                //int tam = int.Parse(Console.ReadLine());

                //int[,] matriz = new int[tam, tam];
                //for (int i = 0; i < matriz.GetLength(0); i++)
                //{
                //    for (int j = 0; j < matriz.GetLength(1); j++)
                //    {
                //        if (i == j)
                //        {
                //            matriz[i, j] = 1;
                //        }
                //        Console.Write(matriz[i, j] + " ");
                //    }
                //    Console.WriteLine("");
                //}
            }


            ////////////////////LISTAS///////////////
            /*Teoria:
                List<TIPO> nombre = new List <TIPO>();             
             */
            //List<int> ejint = new List<int>();
            //List<float> ejfloat = new List<float>();
            //List<double> ejdouble = new List<double>();
            //List<char> ejchar = new List<char>();
            //List<string> ejstring = new List<string>();
            //List<bool> ejbool = new List<bool>();
            //ejint.Add(10);
            //ejint.Add(100);
            //ejint.Add(1);
            //ejint.Add(133);
            //ejint.Remove(100); //elimina los datos que sean 100 (dentro de la casilla)
            //ejint.RemoveAt(0); //elimina ese indice
            //ejint[1] = -40;    //cambias el valor dentro de un indice            
            //foreach (int number  in ejint)
            //{
            //    Console.WriteLine(number);
            //}

            //List<int> ejemplo = new List<int>();
            //ejemplo.Add(1);
            //ejemplo.Add(2);
            //ejemplo.Add(3);
            //ejemplo.Add(4);
            //foreach (int number in ejemplo)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine("par");

            //    }
            //    else
            //    {
            //        Console.WriteLine("impar");
            //    }
            //}


        }
    }
}   
