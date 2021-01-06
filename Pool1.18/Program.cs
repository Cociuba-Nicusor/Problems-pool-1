using System;

namespace Pool1._18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Afisati descompunerea in factori primi ai unui numar n.
            int n, exp = 0, div = 2;
            Console.WriteLine("Introduceti numarul n:");
            n = int.Parse(Console.ReadLine());
            while (n != 1)
            {
                while (n % div == 0)
                {
                    exp++;
                    n = n / div;
                }

                if (exp != 0)
                {
                    Console.WriteLine($"{div} ^ {exp}");
                    div=div+1;
                    exp = 0;
                }

            }
            Console.ReadKey();
        }
    }
}
