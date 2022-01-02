using System;

namespace Secao03
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int[] vetor = new int[10];

            for (int i = 0; i < 10; i++)
            {
                x = int.Parse(Console.ReadLine());

                if (x <= 0)
                {
                    vetor[i] = 1;
                }
                else
                {
                    vetor[i] = x;
                }

                Console.WriteLine($"X[{i}] = {vetor[i]}");
            }
        }
    }
}
