using System;

namespace MatrizNxN
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] value = Console.ReadLine().Split(' ');
            int N = int.Parse(value[0]);
            int M = int.Parse(value[1]);
            
            int[,] matriz = new int[N, M];

            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                value = Console.ReadLine().Split(' ');

                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    matriz[linha, coluna] = int.Parse(value[coluna]);
                }
            }
            int position = int.Parse(Console.ReadLine());
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    if (matriz[linha, coluna] == position)
                    {
                        Console.WriteLine($"Position {linha},{coluna}:");                        
                        if (coluna - 1 >= 0)
                        {
                            Console.WriteLine($"Left: {matriz[linha, coluna - 1]}");
                        }
                        if (coluna + 1 < matriz.GetLength(1))
                        {
                            Console.WriteLine($"Right: {matriz[linha, coluna + 1]}");
                        }
                        if (linha - 1 >= 0)
                        {
                            Console.WriteLine($"Up: {matriz[linha - 1, coluna]}");
                        }
                        if (linha + 1 < matriz.GetLength(0))
                        {
                            Console.WriteLine($"Down: {matriz[linha + 1, coluna]}");
                        }
                    }
                }
            }
            
        }
    }
}


