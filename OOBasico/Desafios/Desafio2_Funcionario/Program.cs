using System;

namespace Desafio2_Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            
            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine());
            funcionario.SalarioLiquido();
           
            Console.WriteLine("\n\nFuncionário:" + funcionario);
            
            Console.Write("\n\nDigite a porcentagem para aumentar o salário: ");            
            double percentual = double.Parse(Console.ReadLine());
            
            funcionario.AumentarSalario(percentual);           
            
            Console.WriteLine("\nDados atualizados:" + funcionario);
        }
    }
}
