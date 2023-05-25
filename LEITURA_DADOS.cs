using System;

class Program {
    public static void Main (string[] args) {

       // Declaracao de variaveis.
       int n1, n2;
       double n3, n4;
       float n5;
       string s;
       bool b1;
       
       // Leitura de inteiros.
       Console.Write("Digite um numero inteiro: ");
       n1 = int.Parse(Console.ReadLine()); 
       Console.Write("Digite outro numero inteiro: ");
       n2 = Convert.ToInt32(Console.ReadLine()); // Uma segunda maneira de ler um inteiro.

       // Leitura de valores ponto-flutuante.
       Console.Write("Digite um numero real: ");
       n3 = double.Parse(Console.ReadLine());
       Console.Write("Digite outro numero real: ");
       n4 = Convert.ToDouble(Console.ReadLine()); // Outra forma de converter um numero real.
       Console.Write("Digite mais um numero real: ");
       n5 = float.Parse(Console.ReadLine()); // Conversao do tipo string para o tipo float.
       
       // Leitura de um booleano.
       Console.Write("Digite um booleano(true ou false): ");
       b1 = bool.Parse(Console.ReadLine());

       // Leitura de strings.
       Console.Write("Digite um texto qualquer(string): ");
       s = Console.ReadLine(); // Ao ler uma string nao precisamos fazer conversao.
       Console.ReadKey();

    }
} 
