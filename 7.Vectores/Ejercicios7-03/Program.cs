using System;

namespace Ejercicios7_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] frase = new char[30]; 
            char[] frase2 = new char[30];
            int c = 0;
            char charIngresado, charReemplazado;

            Console.WriteLine("Ingrese una frase: ");
            frase[c] = char.Parse(Console.ReadLine());
            frase2[c] = frase[c];
            while (frase[c] != '.' && c < 30)
            {
                c++;
                frase[c] = char.Parse(Console.ReadLine());
                frase2[c] = frase[c];
            }

            frase[c] = '\0';
            frase2[c] = frase[c];

            Console.WriteLine("Ingrese el caracter que desea reemplazar:");
            charReemplazado = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nuevo caracter para reemplazar a '" + charReemplazado + "'.");
            charIngresado= char.Parse(Console.ReadLine());

            for (int i = 0; i < 30; i++)
            {
                if (frase2[i] == charReemplazado)
                    frase2[i] = charIngresado;
            }
            
            c = 0;
            Console.WriteLine("Frase original:");
            while (frase[c] != '\0')
            {
                Console.Write(frase[c]);
                c++;
            }
            Console.WriteLine(" ");            
            Console.WriteLine("Carater a reemplazar: " + charReemplazado + ".");
            
            Console.WriteLine("Nuevo caracter: " + charIngresado + ".");
            
            Console.WriteLine("Frase con el caracter reemplazado: ");
            
            c = 0;
            while (frase2[c] != '\0')
            {
                Console.Write(frase2[c]);
                c++;
            }
        }
    }
}
