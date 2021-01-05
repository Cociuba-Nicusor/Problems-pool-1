using System;

namespace Pool1._17
{
    class Program
    {
        static void Main(string[] args)
        {
            // Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid.
            int a, b, p;
            Console.WriteLine("Introduceti primul numar:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea numar:");
            b = int.Parse(Console.ReadLine());
            p = a * b;
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                if (b > a)
                    b = b - a;
            }
            Console.WriteLine($"Cel mai mare divizor comun a celor doua numere este {a}.");
            Console.WriteLine($"Cel mai mic multiplu comun a celor doua numere este {p/ a}");
            Console.ReadKey();
        }
    }
}
