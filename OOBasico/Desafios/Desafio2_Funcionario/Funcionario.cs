using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Desafio2_Funcionario
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto, Imposto;
        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += SalarioBruto * (porcentagem / 100.0);
        }

        public override string ToString()
        {
            return $"" +
                $"{Nome}, R$" +
                $"{SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture)}";
        }

    }
}
