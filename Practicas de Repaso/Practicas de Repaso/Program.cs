using System;
using System.Collections.Generic;

namespace Practicas_de_Repaso
{
    class Program
    {
        static void Main(string[] args)
        {
            //te pregunta cuantos numeros quieres introducir mira sin son pares o impares y los mete en arrais concretos para los opares y para los impares

            //Console.Write("cuantos numeros quieres introducir: ");
            //int tamnum = int.Parse(Console.ReadLine());
            //int[] num = new int[tamnum];
            //int[] ARpar = new int[tamnum];
            //int[] ARimpar = new int[tamnum];
            //int par = 0;
            //int impar = 0;
            //for (int i = 0; i < num.Length; i++)
            //{
            //    num[i] = int.Parse(Console.ReadLine());
            //    if (num[i] % 2 == 0)
            //    {
            //        par++;
            //        num[i] = ARpar[i];
            //    }
            //    else
            //    {
            //        impar++;
            //        num[i] = ARimpar[i];
            //    }
            //}
            //Console.WriteLine("numeros Pares :" + par + "  numeros impares: " + impar);
            //Console.WriteLine("Lista de numeros pares");
            //for (int i = 0; i < ARpar.Length; i++)
            //{
            //    Console.WriteLine("lista de numeros pares: " + ARpar[i]);


            //}

            //Console.WriteLine("Lista de numeros impares");
            //for (int i = 0; i < impar; i++)
            //{

            //    Console.WriteLine("lista de numeros impares: " + ARimpar[i]);

            //}

            //table de multiplicar almacenada en un array
            //Console.Write("que Tabla quieres?");
            //int tabla = int.Parse(Console.ReadLine());
            //int[] almacen = new int[11];
            //for (int i = 1; i < almacen.Length; i++)
            //{
            //    //tabla = tabla * i;
            //    //almacen[i] = tabla;
            //    almacen[i] = tabla * i;
            //}
            //for (int i = 0; i < almacen.Length; i++)
            //{
            // Console.WriteLine("dentro del array: "+ almacen[i]);
            //}



            //Console.Write("¿Que tabla quieres?: ");
            //int tabla = int.Parse(Console.ReadLine());
            //Console.WriteLine("el resultado es: ");
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(tabla+" x "+ i + " = "+(tabla*i));
            //}



            //enumer los impares hasta llegar al numero indicado

            //Console.WriteLine("hasta que numero quieres?: ");
            //int objetivo = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= objetivo; i+=2 /*i++*/)
            //{
            //    //if (i % 2 != 0)
            //    //{
            //        Console.WriteLine(i);
            //    //}
            //}





            //Console.WriteLine("cuantas repeticiones quieres? ");
            //int repe = int.Parse(Console.ReadLine());
            //string[] arr = new string[repe];
            //for (int i = 0; i <= repe; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i <= repe; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write(i);
            //    }
            //    Console.WriteLine();

            //}

            //for (int i = 0; i <= repe; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}

            //int b = 1;
            //for (int i = 0; i <= repe; i++)
            //{
            //    for (int j = 1; j < i; j++)
            //    {
            //        Console.Write(b);
            //        b++;
            //    }
            //    Console.WriteLine();
            //}



            //int[] arr = new int[10];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = i+1;
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //Console.Write("Introduce 3 numeros: ");
            //int[] arr1 = new int[3];
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //     arr1[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = arr1.Length-1; i >= 0; i--)
            //{
            //    Console.WriteLine(arr1[i]);
            //}


            //Console.WriteLine("cuantas sumas quieres hacer?: ");
            //    int j = int.Parse(Console.ReadLine());
            //Console.WriteLine("introduce los numeros: ");
            //int[] num = new int[j];
            //int resultado = 0;
            //for (int i = 0; i < num.Length; i++)
            //{
            //    num[i] = int.Parse(Console.ReadLine());
            //    resultado = resultado + num[i];
            //}
            //Console.WriteLine("el resultado es: " + resultado);



            //Console.WriteLine("como de grande lo quieres?");
            //int x = int.Parse(Console.ReadLine());
            //int[] arr1 = new int[x];
            //int[] arr2 = new int[x];
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    arr1[i] = int.Parse(Console.ReadLine());
            //    arr2[i] = arr1[i];
            //    Console.WriteLine(arr2[i]);
            //}


            //Console.WriteLine("como de grande lo quieres?");
            //int x = int.Parse(Console.ReadLine());
            //int[] arr = new int[x];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //bool duplicado = false;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j <= i && !duplicado; j++)
            //    {
            //        if (arr[j] == arr[i])
            //        {
            //                Console.WriteLine("Hay algun numero duplicado");
            //                duplicado = true;
            //        }

            //    }
            //}



            //Console.WriteLine("como de grande lo quieres?");
            //int x = int.Parse(Console.ReadLine());
            //int[] arr = new int[x];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i+1; j < arr.Length; j++)
            //    {
            //        if (arr[i] > arr[j])
            //        {
            //            int save = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = save;
            //        }
            //    }
            //    Console.WriteLine(arr[i]);
            //}




            //List<int> num = new List<int>();
            //for (int i = 0; i < 10; i++)
            //{
            //    num.Add(i + 1);
            //    Console.WriteLine(num[i]);

            //}



            //Console.Write("Introduce 3 numeros: ");
            //List<int> num = new List<int>();
            //for (int i = 0; i < 3; i++)
            //{
            //    num.Add(int.Parse(Console.ReadLine()));
            //}
            //for (int i = num.Count - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(num[i]);
            //}

            //Console.WriteLine("como de grande lo quieres?");
            //int x = int.Parse(Console.ReadLine());
            //List<int> num = new List<int>(); 
            //Console.WriteLine("introduce los numeros");
            //for (int i = 0; i < x; i++)
            //{
            //    num.Add(int.Parse(Console.ReadLine()));
            //}

            //for (int i = 0; i < num.Count; i++)
            //{
            //    for (int j = i + 1; j < num.Count; j++)
            //    {
            //        if (num[i] > num[j])
            //        {
            //            int save = num[i];
            //            num[i] = num[j];
            //            num[j] = save;
            //        }
            //    }
            //    Console.WriteLine(num[i]);
            //}



            /////////////////////calculadora///////////
            //se preguntan los dos numeros con los que se hara la cuenta, y despues una lista de opcciones para ejecutar la operacion

            //bool exit = false;
            //do
            //{
            //Console.Write("Primer numero?: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("Segundo numero?: ");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Que operacion quieres: ");
            //Console.WriteLine("1. Suma");
            //Console.WriteLine("2. Resta");
            //Console.WriteLine("3. Multiplicacion");
            //Console.WriteLine("4. Division");
            //Console.WriteLine("5. Exit");
            //int ope = int.Parse(Console.ReadLine());
            //    switch (ope)
            //    {
            //        case 1:
            //            Console.WriteLine(num1 +" + "+num2+ " = "+(num1+num2));
            //            break;
            //        case 2:
            //            Console.WriteLine(num1 + " - " + num2 + " = " + (num1 + num2));
            //            break;
            //        case 3:
            //            Console.WriteLine(num1 + " x " + num2 + " = " + (num1 + num2));
            //            break;
            //        case 4:
            //            Console.WriteLine(num1 + " / " + num2 + " = " + (num1 + num2));
            //            break;
            //        case 5:
            //            Console.WriteLine("Adios");
            //            exit = true;
            //            break;
            //    }
            //} while (exit == false);



            //////////////FUNCIONES DE CALCULADORA///////////////////
            static int PreguntarNumero(string texto)
            {
                Console.Write(texto);
                return int.Parse(Console.ReadLine());
            }
            static int Suma(int x, int y)
            {
                return x + y;
            }
            static int Resta(int x, int y)
            {
                return x - y;
            }
            static int Multiplicacion(int x, int y)
            {
                return x * y;
            }
            static int Division(int x, int y)
            {
                return x / y;
            }


            /////////////////////CALCULADORA CON FUNCIONES/////////////////
            bool exit = false;
            do
            {
                int num1 = PreguntarNumero("Primer numero");
                int num2 = PreguntarNumero("segundo numero");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                int ope = PreguntarNumero("¿Que operacion quieres hacer?");
                switch (ope)
                {
                    case 1:
                        Console.WriteLine(num1 + " + " + num2 + " = " + Suma(num1, num2));
                        break;
                    case 2:
                        Console.WriteLine(num1 + " - " + num2 + " = " + Resta(num1, num2));
                        break;
                    case 3:
                        Console.WriteLine(num1 + " x " + num2 + " = " + Multiplicacion(num1, num2));
                        break;
                    case 4:
                        Console.WriteLine(num1 + " / " + num2 + " = " + Division(num1, num2));
                        break;
                    case 5:
                        Console.WriteLine("Adios");
                        exit = true;
                        break;
                }
            } while (exit == false);



        }
    }
}
