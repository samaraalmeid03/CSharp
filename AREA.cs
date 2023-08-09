// EXERCICIO: Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
// a) a área do triângulo retângulo que tem A por base e C por altura.
// b) a área do círculo de raio C. (pi = 3.14159)
// c) a área do trapézio que tem A e B por bases e C por altura.
// d) a área do quadrado que tem lado B.
// e) a área do retângulo que tem lados A e B.

using System;
using System.Globalization;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, areaTri, areaCirc, areaTrap, areaQuad, areaRet;
            double pi = 3.14159;

            Console.Write("Digite os valores de A, B e C (mesma linha): ");
            string[] valores = Console.ReadLine().Split(' ');
            a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            areaTri = (a * c) / 2.0;
            areaCirc = pi * Math.Pow(c, 2);
            areaTrap = ((a + b) * c) / 2.0;
            areaQuad = Math.Pow(b, 2);
            areaRet = a * b;

            Console.WriteLine($"AREA - TRIANGULO = {areaTri.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"AREA - CIRCULO = {areaCirc.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"AREA - TRAPEZIO = {areaTrap.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"AREA - QUADRADO = {areaQuad.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"AREA - RETANGULO = {areaRet.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
