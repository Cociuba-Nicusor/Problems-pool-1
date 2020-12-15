using System;

namespace Pool1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. 
            double a, b, c;
            Console.WriteLine("Introduceti numarul a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul b:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul c:");
            c = int.Parse(Console.ReadLine());
            if (a < b + c && b < a + c && c < a + b)
            {
                Console.WriteLine($"Numerele {a},{b},{c} pot forma laturile unui triunghi.");
            }
            else
            {
                Console.WriteLine($"Numerele {a},{b},{c} nu formeaza laturile unui triunghi.");
            }
            Console.ReadKey();
        }
    }
}
