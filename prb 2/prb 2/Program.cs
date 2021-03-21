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
            int[] v = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // int result = returnSum(v);
            int result = recursiveSum(v,0);
            Console.WriteLine(result);

        }
        static int recursiveSum(int[] v,int index)
        {
            if(index==v.Length)
            {
                return 0;
            }
            return v[index] + recursiveSum(v, index + 1);
            
        }
        static int returnSum(int[] v)
        {
            int sum = 0;
            for(int i=0;i<v.Length; i++)
            {
                sum += v[i];
            }
            return sum;
                
        }
    }
}
