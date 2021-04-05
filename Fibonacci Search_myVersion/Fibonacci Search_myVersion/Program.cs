using System;
namespace Fibonacci_Search_myVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            int p;
            float a = 0, b = 1, x, i;
            Console.WriteLine("Introduceti Pozitia: ");
            p =int.Parse(Console.ReadLine());
            int[] v = new int[p]; 
            if (a == 0 && b == 1)
            {
                for (i = 0; i < v.Length; i++)
                {
                    x = a + b;
                    a = b;
                    b = x;
                }
            }
            if (p == 0) Console.WriteLine("Numarul de pe pozitia {0} este: {1}", p, a);
            else Console.WriteLine("Numarul de pe pozitia {0} este: {1}", p, b);
          

            Console.ReadKey();
        }
    }
}
