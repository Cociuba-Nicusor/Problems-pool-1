using System;

namespace Pool1._9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Afisati toti divizorii numarului n. 
            int n, i;
            Console.WriteLine("Introduceti numarul n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Divizorii lui n sunt:");
            for (i=1;i<=n;i++)
            if(n%i==0)
            Console.WriteLine($"{i}");
            Console.ReadKey();
            
        }
    }
}
