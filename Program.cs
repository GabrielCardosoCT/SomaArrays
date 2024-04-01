using System;

namespace somalaco
{

    class Program
    {
        static void Main(string[] args)
        {
            //Arrays
            int[] vet1 = new int [5];
            int[] vet2 = new int [5];
            int i = 0;

            // Laço de repetição para a soma das duas arrays 
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("vet1: pos " + (i + 1) + ":");
                vet1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("vet2: pos " + (i + 1) + ":");
                vet2[i] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine();

            Console.WriteLine("Soma: ");

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(vet1[i] + vet2[i] + "");
            }

            Console.ReadKey();
        }
    }
}