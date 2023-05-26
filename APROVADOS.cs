using System;

class Program {
    public static void Main (string[] args) {
        int nota;

        Console.Write("Digite a nota do aluno(a): ");
        nota = Convert.ToInt32(Console.ReadLine());

        if (nota >= 60) {
          Console.WriteLine("O aluno(a) foi aprovado(a)!"); 
          Console.WriteLine("PARABÉNS!");  
        }
        // Quando escrevemos mais de um comando na estrutura condicional o uso de chaves é obrigatório!
        // Quando há apenas um comando o uso de chaves é opcional.
        else {  
           Console.WriteLine("O aluno(a) foi reprovado(a).");
           Console.WriteLine("Precisara fazer a REAVALIAÇÃO!");
        } 

        Console.ReadKey();
    }
}
