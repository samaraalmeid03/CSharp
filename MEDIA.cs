using System;

class Program {
    public static void Main (string[] args) {
        int n1, n2, n3, n4, n5, soma;
        double media;

        Console.Write("Digite o primeiro numero: ");
        n1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo numero: ");
        n2 = int.Parse(Console.ReadLine());

        Console.Write("Digite o terceitro numero: ");
        n3 = int.Parse(Console.ReadLine());

        Console.Write("Digite o quarto numero: ");
        n4 = int.Parse(Console.ReadLine());

        Console.Write("Digite o quinto numero: ");
        n5 = int.Parse(Console.ReadLine());

        soma = n1 + n2 + n3 + n4 + n5;
        media = soma / 5;

        Console.WriteLine($"SOMA = {soma}");
        Console.WriteLine($"MEDIA = {media}");
        Console.ReadKey();
    }
}
