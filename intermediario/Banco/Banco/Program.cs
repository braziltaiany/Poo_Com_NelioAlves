using Banco.Entities;
using System;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Account contaF = new Account(1002, "Maria", 500.0);
            Account contaJ = new BussinessAccount(1003, "Ana", 500.0, 100);

            Console.WriteLine(contaF.Balance);

            contaF.Withdraw(50.0);
            Console.WriteLine(contaF.Balance);

            contaF.Deposit(50.0);
            Console.WriteLine(contaF.Balance);


            Account contaFisica = new Account(1002, "Maria", 0.0);
            BussinessAccount contaJuridica = new BussinessAccount(1003, "Ana", 0.0, 500);
            Account contaFisica2 = contaJuridica;


            //Upcasting
            Account contaPounpanca = new SavingsAccount(1003, "Bethania", 0.0, 0.01);
            Account contaJuridica2 = new BussinessAccount(1002, "Joao", 0.0, 200);

            //Dowcasting
            BussinessAccount contaJuridica3 = (BussinessAccount)contaJuridica;//muito inseguro

            if (contaPounpanca is BussinessAccount)
            {
                BussinessAccount contaJuridica4 = (BussinessAccount)contaPounpanca;
                contaJuridica4.Loan(200.0);
                Console.WriteLine("Loan!!");
            }

            if (contaPounpanca is SavingsAccount)
            {
                SavingsAccount contaPounpanca2 = (SavingsAccount)contaPounpanca;
                contaPounpanca2.UpdateBalance();

                Console.WriteLine("Update");
            }

            //PARTE 3

            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);



        }
    }
}
