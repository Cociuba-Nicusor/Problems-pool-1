using System;

namespace Numere1
{
    class Program
    {
        static void Main(string[] agrs)
        {
            //Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. 
            int a, b;
            float x;
            Console.WriteLine("Introduceti coeficientul lui x.");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti termenul liber.");
            b = int.Parse(Console.ReadLine());
            if (a == 0)
                Console.WriteLine("Ecuatia nu exista.");
            else
                Console.WriteLine($"Solutia ecuatiei este {x = -b / a}.");
            Console.ReadKey();
        }
    }
}