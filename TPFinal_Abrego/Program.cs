using System;

namespace TPFinal_Abrego
{
    class Program
    {
        static void Main(string[] args)
        {
        //Hacer un programa que permita ingresar una lista de números que corta
        //cuando se ingresa un cero.A partir de dichos datos informar:
        //a.El mayor de los números pares.
        //b.La cantidad de números impares.
        //c.El menor de los números primos.
        //Nota: evaluar el uso de una función que analice si un número dado
        //es primo o no y que devuelva true o false según corresponda.

            int mayorPar = 1, cImpar = 0, menorPrimo = 0, n = 1;

            Console.WriteLine("Ingrese una lista de números (Introduzca 0 para finalizar).");
            while (n != 0){
                n = int.Parse(Console.ReadLine());
                if (n != 0)
                {
                    if (n % 2 == 0)
                    {
                        if (mayorPar == 1 || n > mayorPar)
                            mayorPar = n;
                    }
                    else
                    {
                        cImpar++;
                    }
                    if (f_primo(n) == 1)
                        if (menorPrimo == 0 || n < menorPrimo)
                            menorPrimo = n;
                }
            }
            if (mayorPar == 1)
                Console.WriteLine("A. Ningún número par fue ingresado.");
            else
                Console.WriteLine("A. El mayor de los números pares fue el " + mayorPar + ".");
            if ( cImpar == 0)
                Console.WriteLine("B. Ningún número impar fue ingresado.");
            else
                Console.WriteLine("B. La cantidad de números impares ingresados fue de: " + cImpar + ".");
            if (menorPrimo == 0)
                Console.WriteLine("C. Ningún número primo fue ingresado.");
            else
                Console.WriteLine("C. El menor de los números primos ingresados fue el " + menorPrimo + ".");
        }
        static int f_primo(int n)
        {
            int cResto = 0;
            for (int i = 1; i <= n; i++)
                if (n % i == 0)
                    cResto++;
            if (cResto == 2 || n == 1)
                return 1;
            else
                return 0;
        }
    }
}
