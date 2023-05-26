using System;

class Program {
    public static void Main (string[] args) {

       // Declaracao de variaveis.
       int preInc = 7, posInc = 7, preDec = 7, posDec = 7;

       Console.WriteLine($"Pre-incremento = {++preInc}"); //Incrementa e depois executa o comando.
       Console.WriteLine($"Pos-incremento = {posInc++}"); //Executa o comando e depois incrementa.
       Console.WriteLine($"Pre-decremento = {--preDec}"); //Decrementa e depois executa o comando.
       Console.WriteLine($"Pos-decremento = {posDec--}"); //Executa o comando e depois decrementa.
       Console.WriteLine("\nREIMPRIMINDO: ");
       Console.WriteLine($"Pre-incremento = {preInc}");
       Console.WriteLine($"Pos-incremento = {posInc}");
       Console.WriteLine($"Pre-decremento = {preDec}");
       Console.WriteLine($"Pos-decremento = {posDec}");
       Console.ReadKey();
       
    }
} 
