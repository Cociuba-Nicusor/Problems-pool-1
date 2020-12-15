using System;

namespace Pool1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Detreminati daca un an y este an bisect.
            int an;
            Console.WriteLine("Introduceti anul:");
            an = int.Parse(Console.ReadLine());
            if (an % 4 == 0 && an % 100 != 0 || an % 400 == 0) 
            {
                Console.WriteLine($"Anul {an} este bisect.");
            }
            else
            {
                Console.WriteLine($"Anul {an} nu este bisect.");
            }
            Console.ReadKey();
        }
    }
}
