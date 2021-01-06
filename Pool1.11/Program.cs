using System;

namespace Pool1._11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Afisati in ordine inversa cifrele unui numar n. 
            int n, ogl=0, cif;
            Console.WriteLine("Introduceti numarul n:");
            n = int.Parse(Console.ReadLine());
            while(n!=0)
            {
                cif = n % 10;
                ogl = ogl * 10 + cif;
                n = n / 10;
                Console.Write($"{cif}");
            }
            
            Console.ReadKey();  
        }
    }
}
