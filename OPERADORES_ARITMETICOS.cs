using System;

class Program {
    public static void Main (string[] args) {

       // Declaracao de variaveis.
       int a = 5, b= 2, c;
       int soma, subt, mult, quociente, resto;
       double divExata, raizQuadrada, quadrado, cubo, raizCubica;

       // Calculos.
       soma = a + b;
       subt = a - b;
       mult = a * b;
       quociente = a / b;
       resto = a % b; //% Calcula o resto de uma divisao inteira.
       divExata = 9 / 2.0; // Como um dos operandos é real o operador "/" calcula-se a divisao exata ao inves do quociente.
       raizQuadrada = Math.Sqrt(36); // Math.Sqrt calcula a raiz quadrada de 36.
       quadrado = Math.Pow(a, b); // Math.Pow esta elevando "a" ao valor de "b".
       c = b + 1;
       cubo = Math.Pow(c, c);
       raizCubica = Math.Pow(125, 1/3.0);

       //Impressao dos resultados
       Console.WriteLine($"{a} + {b} = {soma}");
       Console.WriteLine($"{a} - {b} = {subt}");
       Console.WriteLine($"{a} * {b} = {mult}");
       Console.WriteLine($"{a} / {b} = {quociente}");
       Console.WriteLine($"{a} % {b} = {resto}");
       Console.WriteLine($"9 / 2.0 = {divExata}");
       Console.WriteLine($"A raiz quadrada de 36 = {raizQuadrada}");
       Console.WriteLine($"{a} elevado a {b} = {quadrado}");
       Console.WriteLine($"{c} elevado a {c} = {cubo}");
       Console.WriteLine($"A raiz cubica de 125 = {raizCubica}");
       Console.ReadKey();     
       
    }
} 
