using System;
using System.Globalization;

namespace Retangulo
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return Largura * 2 + Altura * 2;
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }

        public override string ToString()
        {
            return 
                $"AREA = {Area().ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"PERIMETRO = {Perimetro().ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"DIAGONAL = {Diagonal().ToString("F2", CultureInfo.InvariantCulture)}";
        }


    }
}
