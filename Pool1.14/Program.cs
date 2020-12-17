using System;

namespace Pool1._14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Determianti daca un numar n este palindrom. 
            int n, a, inv;
            Console.WriteLine("Introduceti numarul n:");
            n = int.Parse(Console.ReadLine());
            a = n;
            while (n != 0) 
            {
                inv = inv * 10 + n % 10;
                n = n / 10;
            }
            if (inv == a) 
            {
                Console.WriteLine("Numarul este palindrom.");
            }
           else
            {
                Console.WriteLine("Numarul nu este palindrom.");
            }
            Console.ReadKey();
        }
    }
}
