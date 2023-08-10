// EXERCICIO: Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos",
// indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em ordem crescente ou decrescente.

using System;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite dois numeros inteiros (mesma linha): ");
            string[] valores = Console.ReadLine().Split(' ');
            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);

            if (a > b)
            {
                int troca = a;
                a = b;
                b = troca;
            }

            if (b % a == 0)
            {
                Console.WriteLine("Sao mutiplos!");
            }
            else
            {
                Console.WriteLine("Nao sao multiplos!");
            }
        }
    }
}
