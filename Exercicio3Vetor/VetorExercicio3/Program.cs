using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetorExercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[100];
            Console.WriteLine("Informe os 100 elementos: ");
            Console.ReadLine();
            int impares = 0;
            for (int i = 0; i < 100; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 100; i++)
                if (myArray[i] % 2 != 0)
                    impares++;
                    Console.WriteLine($"Quantidade de números ímpares: {impares}");

            Console.ReadKey();
        }
    }
}
