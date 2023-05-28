using System;

class Program
{
    public static void Main(string[] args)
    {
        // Declaracao de variaveis.
        double numero, raiz;
        
        // Entrada de dados.
        Console.Write("Digite um numero: ");
        numero = Convert.ToDouble(Console.ReadLine());
        
        // Enquanto numero for maior que zero o bloco de comando dentro do while sera executado.
        while (numero > 0)
        {
            raiz = Math.Sqrt(numero);
            Console.WriteLine($"A raiz quadrada de {numero} = {raiz}");

            Console.Write("Digite outro numero: ");
            numero = Convert.ToDouble(Console.ReadLine());
        }      
    }
}
