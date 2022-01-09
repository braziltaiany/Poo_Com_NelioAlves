using System;
using System.Collections.Generic;
using System.Text;
using TransacaoBancaria_TratamentoDeExcecoes.Entities.Exceptions;

namespace TransacaoBancaria_TratamentoDeExcecoes.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance,double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if(Balance < amount)
            {
                throw new DomainExcepiton("Withdraw error: Not enough balance");
            }
            if (WithdrawLimit > amount)
            {
                throw new DomainExcepiton("Withdraw error: The amount exceeds withdraw limit");
            }

            Balance -= amount;
        }
    }
}
