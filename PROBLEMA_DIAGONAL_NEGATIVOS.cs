using System;

class Program
{
    static void Main(string[] args)
    {
        int n, quantNegativos;

        Console.Write("Qual a ordem da matriz? ");
        n = int.Parse(Console.ReadLine());

        int[,] mat = new int[n, n]; // --- > Criação de uma matriz.

        for (int i = 0; i < n; i++)  // ---> Percorre toda a matriz e armazena os valores digitados na linha i, coluna j da matriz.
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("Elemento [" + i + "," + j + "]: ");
                mat[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("DIAGONAL PRINCIPAL:"); // ---> Imprimi a diagonal principal.
        for (int i = 0; i < n; i++) 
        {
            Console.Write(mat[i, i] + " ");
        }

        Console.Write("\nQUANTIDADE DE NEGATIVOS = "); // ---> Faz a contagem do número de negativos.
        quantNegativos = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (mat[i, j] < 0)
                {
                    quantNegativos++;
                }
            }
        }
        Console.WriteLine(quantNegativos);
    }
}
