using System;

namespace Pool1._13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Determianti cati ani bisecti sunt intre anii y1 si y2.
            int y1, y2, i, n=0;
            Console.WriteLine("Introduceti primul an:");
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti ultimul an:");
            y2 = int.Parse(Console.ReadLine());
            for(i=y1;i<=y2;i++)
            {
                if (i % 4 == 0 && i % 100 == 0  i % 400 == 0)
                    n++;
            }
            Console.WriteLine($"Intre anii {y1} si {y2} sunt {n} ani bisecti.");
            Console.ReadKey();

        }
    }
}
