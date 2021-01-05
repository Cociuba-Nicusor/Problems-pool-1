using System;

namespace Pool1._15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se dau 3 numere. Sa se afiseze in ordine crescatoare.
            int a, b, c;
            Console.WriteLine("Introduceti primul numar:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea numar:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al treilea numar:");
            c = int.Parse(Console.ReadLine());
            if (a > b && a >= c)
                if (b >= c)
                    Console.WriteLine($"{c},{b},{a}");
                else
                    Console.WriteLine($"{b},{c},{a}");
            else
                if (b >= a && b >= c)
                if (a >= c)
                    Console.WriteLine($"{c},{a},{b}");
                else
                    Console.WriteLine($"{a},{c},{b}");
            else
                if (c >= a && c >= b)
                if (a >= b)
                    Console.WriteLine($"{b},{a},{c}");
                else
                    Console.WriteLine($"{a},{b},{c}");
            Console.ReadKey();
        }
    }
}
