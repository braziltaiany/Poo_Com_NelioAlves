using System;
using System.Collections.Generic;
using CalculaImposto.Entities;
using System.Globalization;

namespace CalculaImposto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxtPayer> list = new List<TaxtPayer>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char resp = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (resp == 'i' || resp == 'I')
                {
                    Console.Write("Health expenditures: ");
                    double healf = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, anualIncome, healf));
                }
                else if (resp == 'c' || resp == 'C')
                {
                    Console.Write("Number of employees: ");
                    double nEmployees = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Company(name, anualIncome, nEmployees));
                }
                else
                {
                    Console.WriteLine("Option invalid");
                }


            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double sumTotal = 0;
            foreach (TaxtPayer taxtPayer in list)
            {
                Console.WriteLine($"{taxtPayer.Name}: $ {taxtPayer.Tax().ToString("F2",CultureInfo.InvariantCulture)}");
                sumTotal += taxtPayer.Tax();
            }

            Console.WriteLine("TOTAL TAXES: $ " + sumTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
