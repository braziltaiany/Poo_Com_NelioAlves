using System;
using System.Collections.Generic;
using System.Text;

namespace CalculaImposto.Entities
{
    abstract class TaxtPayer
    {
        public string Name { get; set; }
        public double AnualIconme { get; set; }

        protected TaxtPayer(string name, double anualIconme)
        {
            Name = name;
            AnualIconme = anualIconme;
        }

        public abstract double Tax();
    }
}
