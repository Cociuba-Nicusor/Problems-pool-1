using System;

namespace _1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Determinati daca n se divide cu k, unde n si k sunt date de intrare. 
            int n, k;
            Console.WriteLine("Introduceti valoarea lui n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea lui k:");
            k = int.Parse(Console.ReadLine());
            if (n % k == 0)
            {
                Console.WriteLine("Numarul n se divide cu numarul k.");
            }
            else 
            {
                Console.WriteLine("Numarul n nu se divide cu numarul k.");
            }
            Console.ReadKey();

        }
    }
}
