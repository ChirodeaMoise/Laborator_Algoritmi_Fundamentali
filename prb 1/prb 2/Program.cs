using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prb_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int i;
            int s = 0;
            int[] v = new int[100];
            Console.Write("n:");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                s += v[i];
            }
            Console.Write("Suma:");
            Console.Write(s);

        }
    }
}
