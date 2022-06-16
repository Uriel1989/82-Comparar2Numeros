using System;

/*Pedir dos números al usuario por teclado y decir que número es el mayor.
 */
namespace _82_Comparar2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese 2 numeros para determinar cual es el mayor");

            int a = Convert.ToInt32(Console.ReadLine());

            int b = Convert.ToInt32(Console.ReadLine());
        
            if(a > b)
            {
                Console.WriteLine("El mayor es: " + a);
            }
            else
            {
                Console.WriteLine("El mayor es: " + b);

            }
        }
    }
}
