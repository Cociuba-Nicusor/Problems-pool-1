using System;

namespace Pool1._12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]. 
            int a, b, n, nr = 0, i;
            Console.WriteLine("Introduceti valoarea de unde incepe intervalul:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea  unde se termina intervalul:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea lui n:");
            n = int.Parse(Console.ReadLine());
            for(i=a;i<=b;i++)
            {
                if (i % n == 0)
                    nr++;

            }
            Console.WriteLine($"In interval sunt {nr} numere divizibile cu {n}.");
            Console.ReadKey();


        }
    }
}
