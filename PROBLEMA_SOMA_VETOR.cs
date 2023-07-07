using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        int n;
        double soma, media;

        Console.Write("Quantos numeros voce vai digitar? ");
        n = int.Parse(Console.ReadLine());

        double[] vet = new double[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Digite um numero: ");
            vet[i] = double.Parse(Console.ReadLine(), CI);
        }

        Console.Write("\nVALORES = ");
        for (int i = 0; i < n; i++) 
        {
            Console.Write(vet[i].ToString("F1", CI) + " ");
        }

        Console.Write("\nSOMA = ");
        soma = 0;
        for (int i = 0; i < n; i++) 
        {
            soma = soma + vet[i];
        }
        Console.Write(soma.ToString("F2", CI));

        media = soma / n;
        Console.WriteLine("\nMEDIA = " + media.ToString("F2", CI));
    }
}
