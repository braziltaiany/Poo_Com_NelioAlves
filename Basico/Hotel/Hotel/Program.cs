using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Registro[] estudante = new Registro[10];
            
            Console.Write("Quantos quartos serão alugados? ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Aluguel #{i + 1}:");
                
                Console.Write($"Nome: ");
                string nome = Console.ReadLine();
                
                Console.Write($"Email: ");
                string email = Console.ReadLine();
                
                Console.Write($"Quarto: ");
                int nQuarto = int.Parse(Console.ReadLine());

                estudante[nQuarto] = new Registro { Nome = nome, Email = email };
            }

            for (int i = 0; i < 10; i++)
            {
                if (estudante[i] != null)
                {
                    Console.WriteLine($"{i}: {estudante[i].Nome}, {estudante[i].Email}");
                }
            }


        }
    }
}
