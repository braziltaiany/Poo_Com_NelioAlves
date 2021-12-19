using System;
using System.Globalization;

namespace Desafio1_Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo;

            retangulo = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = " + retangulo.Area().ToString("F2",CultureInfo.InvariantCulture));
           
        }
    }
}
