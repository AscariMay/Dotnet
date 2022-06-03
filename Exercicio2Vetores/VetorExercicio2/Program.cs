using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetorExercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe os 20 elementos do Array: ");
            int[] myArray = new int[20];

            for (int i = 0; i < 20; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }

            int maior = myArray[0];
            var posicaoMaior = 0;
            for (int i = 0; i < 20; i++)
            {
                if (myArray[i] > maior)
                {
                    maior = myArray[i];
                    posicaoMaior = i;
                }
            }
            Console.WriteLine($"Maior valor do array: {maior} Posicao: [{posicaoMaior}]");

            int menor = myArray[0];
            var posicaoMenor = 0;
            for (int i = 0; i < 20; i++)
            {
                if (myArray[i] < menor)
                {
                    menor = myArray[i];
                    posicaoMenor = i;
                }
            }
            Console.WriteLine($"Menor valor do array: {menor} Posicao: [{posicaoMenor}]");
            Console.ReadLine();

            /*Console.WriteLine("Maior valor do array: " + myArray.Max());
            Console.WriteLine("Menor valor do array: " + myArray.Min());*/
        }
    }
}
