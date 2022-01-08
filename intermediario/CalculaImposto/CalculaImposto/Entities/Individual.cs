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

            if (AnualIconme < 20000.00)
            {
                return AnualIconme * 0.15 - HealthExpenditures * 0.5;

            }
            else
            {
                return AnualIconme * 0.25 - HealthExpenditures * 0.5;
            }

        }
    }
}
