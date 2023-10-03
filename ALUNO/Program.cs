using System;
using System.Globalization;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno alun = new Aluno();

            Console.Write("Nome do aluno: ");
            alun.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno");
            alun.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            alun.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            alun.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("NOTA FINAL = " + alun.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            
            if (alun.Aprovado())
            {
                Console.WriteLine("\nAPROVADO!");
            }
            else
            {
                Console.WriteLine("\nREPROVADO!");
                Console.WriteLine("FALTARAM " + alun.NotaFaltante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
        }
    }
}
