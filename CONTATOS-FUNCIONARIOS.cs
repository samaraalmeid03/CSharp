using System;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] Cadastro = new string[3,2]; //Declaração da matriz Cadastro.

            //Entrada de dados:
            Console.WriteLine("Por favor, informe os dados solicitados:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\nNome do funcionário: ");
                Cadastro[i, 0] = Console.ReadLine();
                Console.Write("\nTelefone...........: ");
                Cadastro[i, 1] = Console.ReadLine();
            }

            //Exibição de lista de opções.
            int codigo = 0;
            Console.WriteLine("\nDIGITE O CÓDIGO CORRESPONDENTE À AÇÃO QUE DESEJA REALIZAR: ");
            Console.WriteLine("0 - Fazer uma consulta pelo nome do funcionário");
            Console.WriteLine("1 - Mostrar todos os registros");
            Console.WriteLine("2 - Sair");
            codigo = int.Parse(Console.ReadLine());

            while (codigo != 2) //Enquanto o código digitado for diferente de 2 repete.
            {
                if (codigo == 1) //Se o código informado for 1...
                {
                    Console.WriteLine("\nLISTAGEM DE CONTATOS:"); 
                    MostrarRegistros(Cadastro); //Todos os registros são mostrados.
                }

                else if (codigo == 0) //Se o código for igual a 0...
                {
                    FazerConsulta(Cadastro); //Faz a chamada do método e realiza consulta.
                }

                else //Se o usuário digitar um código inválido (fora do intervalo 0-2)...
                {
                    Console.WriteLine("\nDIGITE UM CÓDIGO VÁLIDO!"); //Mensagem de alerta é exibida.
                }

                Console.WriteLine("\nDIGITE O CÓDIGO CORRESPONDENTE À AÇÃO QUE DESEJA REALIZAR: ");
                Console.WriteLine("0 - Fazer uma consulta pelo nome do funcionário");
                Console.WriteLine("1 - Mostrar todos os registros");
                Console.WriteLine("2 - Sair");
                codigo = int.Parse(Console.ReadLine());
            } 
        }

        //Métodos:
        static void MostrarRegistros (string[,] Cad)  
        {
            for (int i = 0; i < 3; i++) //Percorre toda a matriz e exibe todos os dados contidos nela.
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"Posição [{i},{j}] = {Cad[i, j]}");
                }
            }
        }

        static void FazerConsulta(string[,] Cad) //Busca o telefone do funcionário pelo seu nome.
        {
            bool encontrou = false;

            Console.Write("\nDigite o nome do funcionário: ");
            string nome = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                if (Cad[i, 0] == nome)
                {
                    encontrou = true;
                    Console.WriteLine($"O número deste funcionário é: {Cad[i, 1]}");
                }
            }
            if (!encontrou)
            {
                Console.WriteLine("Funcionário não cadastrado!");
            }
        }
    }
}
