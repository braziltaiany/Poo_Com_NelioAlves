using System;
using System.Collections.Generic;
using System.Text;

namespace CalculaImposto.Entities
{
    class Company : TaxtPayer
    {
        public double NumberOfEmployees { get; set; }
        public Company(string name, double anualIconme, double numberOfEmployees) : base(name, anualIconme)
        {
            NumberOfEmployees = numberOfEmployees;
        }
        public override double Tax()
        {
            if(NumberOfEmployees < 10)
            {
                return AnualIconme * 0.16;
            }
            else
            {
                return AnualIconme * 0.14;
            }
           
        }
    }
}
