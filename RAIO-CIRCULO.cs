using System;
using System.Globalization;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, area;
            double pi = 3.14159;

            Console.Write("Digite o raio do circulo: ");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = pi * Math.Pow(raio, 2);

            Console.WriteLine($"Area = {area.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}
