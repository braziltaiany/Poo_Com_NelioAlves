using System;
using System.Collections.Generic;
using System.Text;

namespace CalculaImposto.Entities
{
    class Individual : TaxtPayer
    {
        public double HealthExpenditures { get; set; }
        public Individual(string name, double anualIconme, double healthExpenditures) : base(name, anualIconme)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            return AnualIconme * 1.25 - HealthExpenditures * 1.5;
        }
    }
}
