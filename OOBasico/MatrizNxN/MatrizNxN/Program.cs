using System;

namespace MatrizNxN
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] matriz = new int[N, N];

            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                string[] vetor = Console.ReadLine().Split(' ');
                
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    matriz[linha, coluna] = int.Parse(vetor[coluna]);
                }
            }

            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.Write(matriz[i,i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            
            for(int linha = 0; linha < matriz.GetLength(0); linha++)
            {               
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    if(matriz[linha, coluna] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"Negative numbers = {count}");
        }
    }
}
