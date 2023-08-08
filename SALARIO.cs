// EXERCICIO: Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
// hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas decimais.

using System;
using System.Globalization;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, horasTrab;
            double valorHora, salario;

            Console.Write("Digite seu numero de funcionario: ");
            numero = int.Parse(Console.ReadLine());
            Console.Write("Informe as horas trabalhadas: ");
            horasTrab = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor recebido por hora trabalhada: ");
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = valorHora * horasTrab;

            Console.WriteLine($"\nNUMERO = {numero}");
            Console.WriteLine($"SALARIO = R$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
