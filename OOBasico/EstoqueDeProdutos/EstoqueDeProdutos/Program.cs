using System;
using System.Globalization;

namespace EstoqueDeProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade do produto: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.Write("Dados do produto: " + p);//método override com ToString por isso não preciso chamar cada atributo
        }
    }
}
