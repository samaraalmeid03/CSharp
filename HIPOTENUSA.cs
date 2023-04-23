using System;

class Program {
    public static void Main (string[] args) {
       double cateto1, cateto2, hipotenusa;

       Console.Write("Digite o valor do cateto 1: ");
       cateto1 = double.Parse(Console.ReadLine());

       Console.Write("Digite o valor do cateto 2: ");
       cateto2 = double.Parse(Console.ReadLine());

       hipotenusa = Math.Sqrt(Math.Pow(cateto1,2) + Math.Pow(cateto2,2));

       Console.WriteLine($"HIPOTENUSA = {hipotenusa}");
       Console.ReadKey();
    }
} 
