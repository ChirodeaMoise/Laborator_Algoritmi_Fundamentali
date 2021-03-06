using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_BitStone
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "BitStone";

            reverse(name);
        }

        static void reverse(string name)
        {
            List<int> list = new List<int>();
            int count = 1;
            for (int i = 1; i < name.Length; i++)
            {
                if (char.IsUpper(name[i]))
                {
                    count = 1;
                    list.Add(count);
                }
                else
                    count++;
            }
            list.Add(count);

            //char[] v = new char [name.Length];
            char[] v = name.ToCharArray();
            Array.Reverse(v);
            int k = 0;
            for (int i = list.Count - 1; i >= 0; i--)
            {
                v[k] = char.ToUpper(v[k]);
                k++;
                for (int j = 1; j < list[i]; j++)
                {
                    v[k] = char.ToLower(v[k]);
                    k++;
                }

            }
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i]);
            }
            Console.WriteLine();
        }
    }
}
