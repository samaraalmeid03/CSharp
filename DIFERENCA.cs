// EXERCICIO: Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
// de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

using System;
using System.Globalization;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, diferenca;

            Console.WriteLine("Digite os valores de A, B, C e D:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            diferenca = (a * b) - (c * d);

            Console.WriteLine($"DIFERENCA = {diferenca}");
        }
    }
}