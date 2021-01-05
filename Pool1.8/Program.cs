using System;

namespace Pool1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se dau doua variabile numerice a si b ale carori valori sunt date de intrare.
            //Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare. 
            int a, b;
            Console.WriteLine("Introduceti numarul a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul b:");
            b = int.Parse(Console.ReadLine());
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine($"a={a},b={b}");
            Console.ReadKey();
        }
    }
}
