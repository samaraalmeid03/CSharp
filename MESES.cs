using System;

class Program {
    public static void Main (string[] args) {
        // Declaração de variáveis.
        int numMes;
        string nomeMes;
        // Exibição de dados na tela.
        Console.Write("Digite o numero do mes: ");
        numMes = Convert.ToInt32(Console.ReadLine());
        // Estrutura condicional de escolha.
        // Caso o número digitado pelo usuário for 1 "Janeiro" é atribuído à variável nomeMes, caso 2 "Fevereiro" é atribuído a nomeMes e assim por diante.
        switch (numMes) 
        {
            case 1:   nomeMes = "Janeiro";
                      break;
            case 2:   nomeMes = "Fevereiro";
                      break;
            case 3:   nomeMes = "Março";
                      break;
            case 4:   nomeMes = "Abril";
                      break;
            case 5:   nomeMes = "Maio";
                      break;
            case 6:   nomeMes = "Junho";
                      break;
            case 7:   nomeMes = "Julho";
                      break;
            case 8:   nomeMes = "Agosto";
                      break;
            case 9:   nomeMes = "Setembro";
                      break;
            case 10:  nomeMes = "Outubro";
                      break;
            case 11:  nomeMes = "Novembro";
                      break;
            case 12:  nomeMes = "Dezembro";
                      break;
            default:  nomeMes = "Mes invalido";
                      break;  
            // Default é executado quando todas as condições acima testarem falso.                  
        }
        Console.WriteLine();
        Console.WriteLine($"Mes digitado = {nomeMes}");

        switch (nomeMes)
        {   
            case "Janeiro":
            case "Março":
            case "Maio":
            case "Julho":
            case "Agosto":
            case "Outubro":
            case "Dezembro":
                 Console.WriteLine("Este mes tem 31 dias.");
                 break;
            case "Fevereiro":
                 Console.WriteLine("Este mes tem 28 ou 29 dias.");
                 break;
            case "Abril":
            case "Junho":
            case "Setembro":
            case "Novembro":
                 Console.WriteLine("Este mes tem 30 dias.");
                 break;
            default:
                 Console.WriteLine("Nao e possivel informar o numero de dias!");
                 break;
        }
        Console.ReadKey();
    }
}
