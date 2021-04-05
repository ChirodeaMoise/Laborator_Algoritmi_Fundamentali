using System;

namespace Turnurile_din_Hanoi_myVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            char from = 'A', to = 'B', help = 'C';
            do
            {
                Console.Write("  numarul de discuri: ");
                x = int.Parse(Console.ReadLine());
              
            } 
            while (x == -10 || x > 10);
            Console.WriteLine("  baza = A, tinta = B, ajutor = C");
            hanoi(x, from, to, help);

            Console.Read();
        }
        static void hanoi(int x, char from, char to, char help)
        {
            if (x > 0)
            {
                hanoi(x - 1, from, help, to);
                move(x, from, to);
                hanoi(x - 1, help, to, from);
            }

        }

        static void move(int x, char from, char to)
        {
            Console.WriteLine("  Discul " + x + " de pe " + from + " pe " + to);
        }
    }
}
