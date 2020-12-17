using System;

namespace Pool1._10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test de primalitate: determinati daca un numar n este prim.
            int n, j, a=0;
            Console.WriteLine("Introduceti numarul n:");
            n = int.Parse(Console.ReadLine());
            for (j = 2; j < n; j++)
                if (n % j == 0)
                    a++;
            if(a==0)
            {
                Console.WriteLine($"Numarul {n} este prim.");
            }
            else
            {
                Console.WriteLine($"Numarul {n} nu este prim.");
            }
            Console.ReadKey();
        }
    }
}
