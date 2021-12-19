using System;

namespace Cadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1, p2;
           
            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine(" DADOS DA PRIMEIRA PESSOA");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();           

            Console.Write("Idade: ");
            p1.Idade = byte.Parse(Console.ReadLine());
                       
            Console.WriteLine("\n DADOS DA SEGUNDA PESSOA");
            
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();

            Console.Write("Idade: ");
            p2.Idade = byte.Parse(Console.ReadLine());
            
            Console.Write("\n A pessoa mais velha é: ");

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine(p1.Nome);
            }
            else
            {
                Console.WriteLine(p2.Nome);
            }
        }
    }
}
