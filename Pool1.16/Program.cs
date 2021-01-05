using System;

namespace Pool1._16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se dau 5 numere. Sa se afiseze in ordine crescatoare.
            int a, b, c, d, e, aux;
            Console.WriteLine("Introduceti primul numar:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea numar numar:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al teilea numar:");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al patrulea numar:");
            d = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al cincilea numar:");
            e = int.Parse(Console.ReadLine());
            if (a > b)
            { 
                aux = a;
                a = b;
                b = aux; 
            }

            if (a > c)
            {
                aux = a;
                a = c;
                c = aux;
            }
            if (a > d)
            {
                aux = a;
                a = d;
                d = aux;
            }
            if (a > e)
            {  
                aux = a;
                a = e;
                e = aux;
            }
            if (b > c)
            {
                aux = b;
                b = c;
                c = aux;
            }
            if (b > d)
            { 
                aux = b;
                b = d;
                d = aux;
            }
            if (b > e)
            {
                aux = b;
                b = e;
                e = aux;
            }
            if (c > d)
            {
                aux = c;
                c = d;
                d = aux;
            }
            if (c > e)
            {
                aux = c;
                c = e;
                e = aux;
            }
            if (d > e)
            {
                aux = d;
                d = e;
                e = aux;
            }
            Console.WriteLine($"{a},{b},{c},{d},{e}");
            Console.ReadKey();



        }
    }
}
