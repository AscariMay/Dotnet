using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetorExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            // eu atribuo direto a quantidade
            int[] vetA = new int[10] {1,2,3,4,5,6,7,8,9,10};
            int[] vetB = new int[10] {11,12,13,14,15,16,17,18,19,20};
            int[] vetC = new int[20];
            int i = 0;
            int iA = 0, iB = 0, iC;
            for(i = 0; i < vetA.Length; i++)
            {
                Console.Write(vetA[i]+" ");
            }
            Console.WriteLine();
            for (i = 0; i < vetB.Length; i++)
            {
                Console.Write(vetB[i]+" ");
            }
            Console.WriteLine();

            for (iC = 0; iC < 20; iC++)
            {
                vetC[iC] = vetA[iA];
                iA++;
                iC++;

                vetC[iC] = vetB[iB];
                iB++;
            }
            Console.WriteLine(String.Join(", ",vetC));
            Console.ReadKey();
        }
    }
}
