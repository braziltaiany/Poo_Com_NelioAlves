using System;

namespace Cadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            int idadeP1=0, idadeP2=0, i= 0;
            string nome1="", nome2="";

            Pessoa nome, idade;
            nome = new Pessoa();
            idade = new Pessoa();

            Console.WriteLine("Escreva o nome:");
            nome.Nome = Console.ReadLine();
            nome1 = nome.Nome;

            Console.WriteLine("Escreva a idade:");
            idade.Idade = byte.Parse(Console.ReadLine());
            idadeP1 = idade.Idade;
            
            Console.WriteLine("\n ****************************************");
            
            Console.WriteLine("Escreva o nome:");
            nome.Nome = Console.ReadLine();
            nome2 = nome.Nome;

            Console.WriteLine("Escreva a idade:");
            idade.Idade = byte.Parse(Console.ReadLine());
            idadeP2 = idade.Idade;
            
            Console.WriteLine("\n ****************************************");
            Console.Write("\n A pessoa mais velha é: ");

            if (idadeP1 > idadeP2)
            {
                Console.WriteLine(nome1);
            }
            else
            {
                Console.WriteLine(nome2);
            }



        }
    }
}
