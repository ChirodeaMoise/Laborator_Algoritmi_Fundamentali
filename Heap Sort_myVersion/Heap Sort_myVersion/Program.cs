using System;

namespace Heap_Sort_myVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            HeapSort s = new HeapSort();
            int[] v = { 0, 9, 31, 1, 23, 100, 8, 43, 12, 21, 99, 26};
            s.heapSort(v);
            for (int i = 1; i < v.Length; i++)
            {
                Console.Write(v[i] + " ");
            }
            Console.WriteLine();
        
        }
    }
    
}
