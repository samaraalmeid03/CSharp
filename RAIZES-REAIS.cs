using System;
using System.Globalization;

namespace Projeto1
{
    class Eq2Grau
    {
        //Variável interna privada:
        private double _a; 

        //Propriedade pública:
        public double a 
        {
            get { return _a; }
            set { _a = value; }
        }

        private double _b;

        public double b
        {
            get { return _b; }
            set { _b = value; }
        }

        private double _c;

        public double c
        {
            get { return _c; }
            set { _c = value; }
        }

        private double _Delta;

        public double Delta
        {
            get { return _Delta; }
            set { _Delta = value; }
        }

        private double _Raiz1;

        public double Raiz1
        {
            get { return _Raiz1;  }
            set { _Raiz1 = value; }
        }

        private double _Raiz2;

        public double Raiz2
        {
            get { return _Raiz2; }
            set { _Raiz2 = value; }
        }

        //Métodos:
        public void CalcDelta ()
        {
            _Delta = Math.Pow(b, 2) - 4 * a * c;
        }

        public void CalcRaizes ()
        {
            _Raiz1 = (-b + Math.Sqrt(Delta)) / (2 * a);
            _Raiz2 = (-b - Math.Sqrt(Delta)) / (2 * a);
        }
    }  

    class Program
    {
        static void Main(string[] args)
        {
            Eq2Grau Equacao = new Eq2Grau(); //Instaciando um objeto do tipo Eq2Grau.

            //Entrada de dados:
            Console.Write("Digite o valor do coeficiente A: ");
            Equacao.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o valor do coeficiente B: ");
            Equacao.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o valor do coeficiente C: ");
            Equacao.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Equacao.CalcDelta();

            Console.WriteLine($"\nDELTA: {Equacao.Delta.ToString("F3", CultureInfo.InvariantCulture)}\n");

            if (Equacao.Delta > 0) //Se o Delta for maior que zero...
            {
                Equacao.CalcRaizes(); //Chamada do método CalcRaizes.

                //Exibição de resultados:
                Console.WriteLine("ESTA EQUAÇÃO POSSUI DUAS RAÍZES REAIS:");
                Console.WriteLine($"RAIZ 1 = {Equacao.Raiz1.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"RAIZ 2 = {Equacao.Raiz2.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (Equacao.Delta == 0) //Se o delta for igual a zero...
            {
                Equacao.CalcRaizes(); //Chamada do método CalcRaizes.

                //Exibição de resultados:
                Console.WriteLine("ESTA EQUAÇÃO POSSUI UMA ÚNICA RAIZ REAL:");
                Console.WriteLine($"RAIZ = {Equacao.Raiz1.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else //Senão...
            {
                Console.WriteLine("ESTA EQUAÇÃO NÃO POSSUI RAÍZES REAIS!\n"); //Impressão de resultado.
            }    
        }       
    }
}
