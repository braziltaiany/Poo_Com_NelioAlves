using System;
using System.Globalization;


namespace Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario f1, f2;
            double sMedio;

            f1 = new Funcionario();
            f2 = new Funcionario();
            
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            
            Console.Write("Salário: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        
            Console.Write("nome: ");
            f2.Nome = Console.ReadLine();
            
            Console.Write("Salário: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            sMedio = (f1.Salario + f2.Salario) / 2.0;

            Console.WriteLine($"O salário médio = {sMedio.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
