using System;
namespace Primer_ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Explicacion 1
            //declaracion de variables de tipo integuer llamada X
            //int x;
            //inicializalicion de variable X con valor 4
            //x = 4;
            //declaracion e inicializacion de y
            //int y = 3;

            //declaracion de Z
            //float z = 7.8f;
            //declaracion de V
            //double w = 7.37d;

            //char letra = 'A';
            //string frase = "el gigante";
            //bool boolverdadero = true;
            //bool boolfalso = false;
            //Console.WriteLine("Hello World!");
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);
            //Console.WriteLine(w);
            //Console.WriteLine(letra);
            //Console.WriteLine(frase);
            //Console.WriteLine(boolfalso);
            //Console.WriteLine(boolverdadero);




            ////////////Ejercicio 1//////////////
            //Console.Write("Primer numero : ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("Segundo numero : ");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("La suma es: " + (num1 + num2));
            //Console.WriteLine("La resta es: " + (num1 - num2));
            //Console.WriteLine("La multiplicacion es: " + (num1 * num2));
            //Console.WriteLine("La division es: " + (num1 / num2));
            //Console.WriteLine("El resto de " + num1 + " y " + num2 + " es: " + (num1 % num2));



            //////////////Ejercicio 2//////////////
            //Console.Write("¿Cuantos años tienes? ");
            //int edad = int.Parse(Console.ReadLine());
            //if (edad >= 18 && edad <= 65)
            //{
            //    Console.WriteLine("Eres mayor de edad y aun eres joven");

            //}
            //else if (edad >= 65)
            //{
            //    Console.WriteLine("Tu eres un abuelo");
            //}
            //else 
            //{
            //    Console.WriteLine("tu eres menor de edad");
            //}



            //////////////Ejercicio 3//////////////
            //Console.Write("¿Que nota tienes?: ");
            //float nota = float.Parse(Console.ReadLine());
            //if (nota > 10 && nota < 0)
            //{
            //    if (nota <= 10 && nota >= 9)
            //    {
            //        Console.WriteLine("Tienes un sobresaliente");
            //    }
            //    else if (nota < 9 && nota >= 7)
            //    {
            //        Console.WriteLine("Tienes un notable");
            //    }
            //    else if (nota < 7 && nota >= 6)
            //    {
            //        Console.WriteLine("Tienes un Bien");
            //    }
            //    else if (nota < 6 && nota >= 5)
            //    {
            //        Console.WriteLine("Tienes un suficiente");
            //    }
            //    else if (nota < 5 && nota >= 0)
            //    {
            //        Console.WriteLine("Insuficiente, estas suspenso");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Nota no valida");
            //}


            //////////////Teoria swich//////////////
            //Console.Write("que numero tienes");
            //int numero = int.Parse(Console.ReadLine());
            //switch (numero)
            //{
            //    case 0:
            //        Console.WriteLine("has introducido un 0");
            //        break;                

            //    case 1:
            //        Console.WriteLine("has introducido un 1");
            //        break;

            //    case 2:
            //        Console.WriteLine("has introducido un 2");
            //        break;       

            //    case 3:
            //        Console.WriteLine("has introducido un 3");
            //        break;      

            //    case 4:
            //       Console.WriteLine("has introducido un 4");
            //        break;
            //}


            ////////////////Ejercicio 4//////////////
            //Console.Write("¿que nota has sacado?");
            //int numero = int.Parse(Console.ReadLine());
            //switch (numero)
            //{
            //    case 0:
            //    case 1:
            //    case 2:
            //    case 3:
            //    case 4:
            //        Console.WriteLine("Has sacado un insuficiente");
            //        break;
            //    case 5:
            //        Console.WriteLine("Has sacado un suficiente");
            //        break;
            //    case 6:
            //        Console.WriteLine("Has sacado un bien");
            //        break;
            //    case 7:
            //        Console.WriteLine("Has sacado un notable");
            //        break;
            //    case 8:
            //        Console.WriteLine("Has sacado un notable");
            //        break;
            //    case 9:
            //        Console.WriteLine("Has sacado un sobresaliente");
            //        break;
            //    case 10:
            //        Console.WriteLine("Has sacado un sobresaliente");
            //        break;
            //      default:
            //        Console.WriteLine("Nota invalida ");
            //        break;

            //}


            ////////////////Ejercicios  Dia 2. Repaso//////////////
            //////////////////Ejercicio 1//////////////
            //Console.Write("¿Numero uno?: ");
            //int numero1 = int.Parse(Console.ReadLine());
            //Console.Write("¿Numero dos?: ");
            //int numero2 = int.Parse(Console.ReadLine());
            //if (numero1 == numero2)
            //{
            //    Console.WriteLine("los dos numeros son iguales: "+numero1+" y "+numero2);
            //} else{
            //    Console.WriteLine("los dos numeros son diferntes: " + numero1 + " y " + numero2);
            //}


            //////////////////Ejercicio 2//////////////
            //Console.Write("¿Numero uno?: ");
            //int numero1 = int.Parse(Console.ReadLine());
            //Console.Write("¿Numero dos?: ");
            //int numero2 = int.Parse(Console.ReadLine());
            //if (numero1 == numero2)
            //{
            //    Console.WriteLine("los dos numeros son iguales: " + numero1 + " y " + numero2);
            //}
            //else
            //{
            //    Console.WriteLine("Son diferentes");
            //    if (numero1 > numero2)
            //    {
            //        Console.WriteLine(numero1 + "es mayor que" + numero2);
            //    }
            //    else 
            //    {
            //        Console.WriteLine(numero2 + "es mayor que" + numero1);
            //    }
            //}


            //////////////////Ejercicio 3//////////////
            ////par o impar
            //Console.Write("Numero a adivinar ");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 2 == 0)
            //{
            //    Console.Write("Es par ");
            //}
            //else
            //{
            //    Console.WriteLine("Es impar");
            //}


            //////////////////Ejercicio 3//////////////
            //multiplo o no 
            //Console.Write("numero 1: ");
            //int num1 = int.Parse(Console.ReadLine());            
            //Console.Write("Numero 2: ");
            //int num2 = int.Parse(Console.ReadLine());
            //if (num1 % num2 == 0 || num2 % num1 == 0)
            //{
            //    Console.Write("Es multiplo ");
            //}
            //else 
            //{
            //    Console.WriteLine("no es multiplo");
            //}


            //////////////////Ejercicio 4//////////////
            //positivo o negativo
            //Console.Write("numero 1: ");
            //int num1 = int.Parse(Console.ReadLine());
            //if (num1 == 0)
            //{
            //    Console.WriteLine("El numero es 0");
            //}

            //else
            //{
            //    if (num1 < 0)
            //    {
            //        Console.WriteLine("el numero es negativo");
            //    }
            //    else
            //    {
            //        Console.WriteLine("el numero es positivo");
            //    }
            //}


            //////////////////Ejercicio 5//////////////
            //interfaz con swich
            //Console.Write("¿Que accion quiere hacer?: ");
            //Console.WriteLine("1. Refran");
            //Console.WriteLine("2. Chiste");
            //Console.WriteLine("3. Insulto");
            //int opt = int.Parse(Console.ReadLine());

            //switch (opt)
            //{
            //    case 1:
            //        Console.WriteLine("Si la vida te da limones, haz limonada");
            //            break;   
            //    case 2:
            //        Console.WriteLine("Van dos y se cae el de en medio");
            //            break;   
            //    case 3:
            //        Console.WriteLine("Mamonazo");
            //            break;

            //    default:
            //        Console.WriteLine("Accion no valida ");

            //        break;
            //}


            //////////////////Ejercicio 6//////////////
            //Nota media

            //Console.WriteLine("¿Cuales son tus notas?: ");
            //Console.Write("1. Matematicas: ");
            //float MAT = float.Parse(Console.ReadLine());
            //Console.Write("2. Lengua: ");
            //float LEN = float.Parse(Console.ReadLine());
            //Console.Write("3. Ingles: ");
            //float ING = float.Parse(Console.ReadLine());
            //float MEDIA = (MAT + LEN + ING)/3;
            //Console.WriteLine("Tu nota media es: " + MEDIA);



            //////////////////Ejercicio 7//////////////
            //criticar alturas, intervalos
            //Console.Write("¿Cual es tu altura en cm? ");
            //float CM = float.Parse(Console.ReadLine());
            //if (CM >= 200)
            //{
            //    Console.WriteLine("Hace viento ahi en las alturas ¿no?");
            //}
            //else if (CM <200 && CM >=170)
            //{
            //    Console.WriteLine("eres alto, mamonazo");
            //}
            //else if (CM < 170 && CM >= 160)
            //{
            //    Console.WriteLine("Altura media, como debe ser");
            //}
            //else
            //{
            //    Console.WriteLine("Eres un tapon");
            //}

        }
    }
}
