using System;

namespace Pool1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile.
            float a, b, c, dt;
            double x1, x2;
            Console.Write("a = ");
            a = float.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = float.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = float.Parse(Console.ReadLine());
            if (a == 0)
            {
                x1 = -c / b;
                Console.WriteLine($"Ecuatia de gradul 1 cu x1 = {x1}.");
            }
            if (c == 0)
            {
                x1 = x2 = -b / (2 * a);
                Console.WriteLine($"Ecuatia are doua solutii egale x1 = x2 = {x1}.");
            }
         
            dt = b * b - 4 * a * c;
            if(dt<0)
            {
                Console.WriteLine($"Ecuatia are solutii in multimea numerelor complexe.");
            }
            if (dt == 0)
            {
                x1 = x2 = -b / (2 * a);
                Console.WriteLine($"Ecuatia nare doua solutii egale x1 = x2 = {x1}.");
            }
              if(dt>0) 
                {
                    x1 = (-b + Math.Sqrt(dt)) / (2 * a);
                    x2 = (-b - Math.Sqrt(dt)) / (2 * a);
                    Console.WriteLine($"Solutiile ecuatiei sunt x1 = {x1}, x2 = {x2}.");
                }
            
            Console.ReadKey();
        }
    }
}
     