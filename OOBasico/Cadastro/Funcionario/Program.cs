using System;
using System.Globalization;


namespace Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario nome, salario;
            double x, y, sMedio;

            nome = new Funcionario();
            salario = new Funcionario();
            
            Console.Write("Nome:");
            nome.Nome = Console.ReadLine();
            
            Console.Write("Salário:");
            salario.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x = salario.Salario;
            
            Console.Write("nome:");
            nome.Nome = Console.ReadLine();
            
            Console.Write("Salário:");
            salario.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y = salario.Salario;

            sMedio = (x + y) / 2.0;

            Console.WriteLine($"O salário médio = {sMedio.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
