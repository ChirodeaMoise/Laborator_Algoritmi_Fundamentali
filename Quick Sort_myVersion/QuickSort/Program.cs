using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creeam un tablou  de elemente nesortate

            Console.WriteLine("Nesortat: ");
             string[] unsorted = { "z", "e", "x", "c", "m", "q", "a" };
           

            // Afisam tabloul nesortat
            for (int i = 0; i < unsorted.Length; i++)
            {
                Console.Write(unsorted[i] + " ");
            }

            Console.WriteLine();

            // Sortam tabloul
            Quicksort(unsorted, 0, unsorted.Length - 1);

            Console.WriteLine("Tablou Sortat: ");
            // Afisam tabloul sortat
            for (int i = 0; i < unsorted.Length; i++)
            {
                Console.Write(unsorted[i] + " ");
            }

            Console.WriteLine();

            Console.ReadLine();
        }

        public static void Quicksort(IComparable[] elements, int left, int right)
        {
            int i = left, j = right;
            IComparable pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Schimb
                    IComparable tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Apel recursiv
            if (left < j)
            {
                Quicksort(elements, left, j);
            }

            if (i < right)
            {
                Quicksort(elements, i, right);
            }
        }
    }
    
}
