using System;
using System.Globalization;

namespace exerc01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite um numero?");
            int numero = int.Parse(Console.ReadLine());

            if (numero < -1)
            {
                Console.WriteLine("Negativo!");
            }
            else
            {
                Console.WriteLine("Não Negativo");
            }
        }
    }
}