using System;

namespace Pool1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor.
            int a, b;
            Console.WriteLine("Introduceti primul numar:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea numar numar:");
            b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"a={+a},b={+b}");
            Console.ReadKey();

        }
    }
}
