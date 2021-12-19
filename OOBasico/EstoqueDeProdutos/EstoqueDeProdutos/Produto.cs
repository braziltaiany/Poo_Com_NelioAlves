using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace EstoqueDeProdutos
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public override string ToString()
        {
            return
                $"{Nome}, " +
                $"R${Preco.ToString(("F2"), CultureInfo.InvariantCulture)}, " +
                $"{Quantidade} unidades, Total: R$" +
                $"{ValorTotalEmEstoque().ToString(("F2"), CultureInfo.InvariantCulture)}";
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }
    }
}
