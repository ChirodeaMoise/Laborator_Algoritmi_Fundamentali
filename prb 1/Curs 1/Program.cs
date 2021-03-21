using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs_1
{
    class Program
    {/*
      *primul element  devine ultimul
      *1 2 3 4
      *2 3 4 1
      *--------
      *3 4 1 2
      */
        static void Main(string[] args)
        {
            int lungime;
            Console.Write("Lungime vector: ");
            lungime = int.Parse(Console.ReadLine());
            int[] vec = new int[lungime];
            
            for (int i = 0; i < lungime; i++)
            {
                vec[i] = i + 1;
            }
            AfisareVec(vec);
            Console.Write("Numar rotatii: ");
            int nrRot = int.Parse(Console.ReadLine());
            int[] output = RotatieVec(vec,nrRot);
            AfisareVec(output);
        }
        static int [] RotatieVec(int[] vec,int nrRot)
        {
            if (nrRot==0)
            {
                return vec;
            }

            int[] aux = new int[vec.Length];
            int j = 0;
            for (int i = nrRot; i < vec.Length; i++)
            {
                aux[j] = vec[i];
                j++;
            }
            for (int i = 0; i < nrRot; i++)
            {
                aux[j] = vec[i];
                j++;
            }
            return aux;
        }


        static void AfisareVec(int[]vec)
        {
            int l = vec.Length;
            for (int i = 0; i < l; i++)
            {
                Console.WriteLine(vec[i] + " ");
            }
        }
    }
}
