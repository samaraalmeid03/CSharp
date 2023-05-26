using System;

class Program {
    public static void Main (string[] args) {
        double salario, inss;

        Console.Write("Infome o salario do empregado: R$ ");
        salario = Convert.ToDouble(Console.ReadLine());

        if (salario <= 1000) {
            inss = salario * 0.08;
        }
        else {
            if (salario <= 1800) {
                inss = salario * 0.10;
            }
            else {
                inss = salario * 0.12;
            }
        }

        Console.Write($"O valor a ser descontado de INSS e R$ {inss:0.00}");
        Console.ReadKey();
        
    }
}
