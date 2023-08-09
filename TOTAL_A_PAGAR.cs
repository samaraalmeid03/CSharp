// EXERCICIO: Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
// codigo de uma peça 2, o número de peças 2 e o valor unitário da peça 2. Calcule e mostre o valor a ser pago.

using System;
using System.Globalization;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod1, cod2, num1, num2;
            double valorUn1, valorUn2, total;

            Console.WriteLine("Digite o codigo, numero de pecas e valor unitario dos dois produtos (teclar enter ao terminar de digitar cada produto):");
            string[] valores = Console.ReadLine().Split(' ');
            cod1 = int.Parse(valores[0]);
            num1 = int.Parse(valores[1]);
            valorUn1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            cod2 = int.Parse(valores[0]);
            num2 = int.Parse(valores[1]);
            valorUn2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            total = (num1 * valorUn1) + (num2 * valorUn2);

            Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}

