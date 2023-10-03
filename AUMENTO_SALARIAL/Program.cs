using System;
using System.Globalization;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            //Entrada de dados.
            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Exibição de informações referentes ao funcionario.
            Console.WriteLine();
            Console.Write("Funcionario: " + func);

            //Entrada do percentual de aumento do salario e chamada da função AumentarSalario().
            Console.WriteLine();
            Console.Write("\nDigite a porcentagem para aumentar o salario: ");
            double pcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(pcent);

            //Impressão dos dados atualizados.
            Console.WriteLine();
            Console.Write("Dados atualizados: " + func);
        }
    }
}
