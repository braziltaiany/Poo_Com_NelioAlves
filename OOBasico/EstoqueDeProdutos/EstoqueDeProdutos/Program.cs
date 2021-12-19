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
            
            Console.Write("Dados do produto: " + p + "\n\n");//método override com ToString NA CLASSE PRODUTO por isso não preciso chamar cada atributo
            
            Console.Write("Digite o número de produtos a ser adicionado: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);            
            Console.WriteLine("Dados do produto atualizado: " + p + "\n\n");

            Console.Write("Digite o número de produtos a ser removido: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine("Dados do produto atualizado: " + p);

        }
    }
}
