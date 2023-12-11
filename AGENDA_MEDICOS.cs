using System;
using System.Globalization;

namespace Projeto1
{
    class Paciente
    {
        public string NomePaciente;
        public Consulta DataConsulta;
        public string HoraConsulta;
        public string NomeMedico;
    }  

    struct Consulta
    {
        public string Dia;
        public string Mes;
        public string Ano;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Paciente[] CadPaciente = new Paciente[3]; 
            
            for (int i = 0; i < 3; i++) 
            {
                Paciente P = new Paciente();
                P.DataConsulta = new Consulta();

                Console.Write("\nNome do paciente.........: ");
                P.NomePaciente = Console.ReadLine();
                Console.Write("Consulta - dia...........: ");
                P.DataConsulta.Dia = Console.ReadLine();
                Console.Write("Consulta - mês...........: ");
                P.DataConsulta.Mes = Console.ReadLine();
                Console.Write("Consulta - ano...........: ");
                P.DataConsulta.Ano = Console.ReadLine();
                Console.Write("Horário da consulta......: ");
                P.HoraConsulta = Console.ReadLine();
                Console.Write("Nome do médico(a)........: ");
                P.NomeMedico = Console.ReadLine();

                CadPaciente[i] = P;
            }

            Console.Write("\nDigite o nome do médico(a): ");
            string Medico = Console.ReadLine();

            MostrarAgendaMedico(CadPaciente, Medico); 
        }

        //Método:
        static void MostrarAgendaMedico(Paciente[] P, string medico)
        {
            Console.WriteLine($"\nAGENDA - DR(A). {medico}:");
            foreach (Paciente x in P)
            {
                if (x.NomeMedico == medico)
                {
                    Console.WriteLine($"\nPaciente...................: {x.NomePaciente}");
                    Console.WriteLine($"Data da consulta...........: {x.DataConsulta.Dia}/{x.DataConsulta.Mes}/{x.DataConsulta.Ano}");
                    Console.WriteLine($"Horário....................: {x.HoraConsulta}");
                    Console.WriteLine("------------------------------------");
                }
            }
        }
    }
}
