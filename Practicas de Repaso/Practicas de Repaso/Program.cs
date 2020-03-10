using System;

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





            Console.WriteLine("cuantas repeticiones quieres? ");
            int repe = int.Parse(Console.ReadLine());
            string[] arr = new string[repe];
            for (int i = 0; i <= repe; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 0; i <= repe; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();

            }
            
            for (int i = 0; i <= repe; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            int b = 1;
            for (int i = 0; i <= repe; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(b);
                    b++;
                }
                Console.WriteLine();
            }


        }
    }
}
