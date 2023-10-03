using System.Globalization;

namespace Projeto1
{
    class Funcionario
    {   
        //Declaração de atributos da classe Funcionario.
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        //Criação de métodos.
        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            double aumento = SalarioBruto * porcentagem / 100.0;
            SalarioBruto += aumento;
        }

        //Formatação dos dados do funcionário que serão exibidos na tela.
        public override string ToString()
        {
            return Nome + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
