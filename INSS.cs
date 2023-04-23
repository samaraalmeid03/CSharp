using System;

class Program {
    public static void Main (string[] args) {
       double salario, inss;
       string nomeColaborador;

       Console.Write("Informe o seu nome completo: ");
       nomeColaborador = Console.ReadLine();

       Console.Write("Infome o seu salario bruto: ");
       salario = double.Parse(Console.ReadLine());

       inss = salario * 0.09;

       Console.Write($"Prezado(a), {nomeColaborador} o valor de INSS a ser descontado e R$ {inss:0.00}.");
       Console.ReadKey();
    }
} 
