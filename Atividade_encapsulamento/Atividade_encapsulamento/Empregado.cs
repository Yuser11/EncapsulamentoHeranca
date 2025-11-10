using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_encapsulamento
{
    internal class Empregado
    {
        public string nome;
        public int idade;
        public string setor;

        private string cpf;
        private string rg;
        private double salario;
        private string departamento;

        public string CPF { get { return cpf; } set { cpf = value; } }
        public string RG { get { return rg; } set { rg = value; } }
        public double Salario { get { return salario; } set { salario = value; } }
        public string Departarmento { get { return departamento; } set { departamento = value; } }



        public void CalcularSalario(double salario)
        {
            double aumento;
            double novoSalario;
            if (salario > 3500)
            {
                 aumento = salario * 0.08;
                 novoSalario = salario + aumento;
            }
            else if (salario > 2500)
            {
                 aumento = salario * 0.10;
                 novoSalario = salario + aumento;
            }
            else
            {
                 aumento = salario * 0.12;
                 novoSalario = salario + aumento;
            }
            Console.WriteLine($"O novo salário é R$:{novoSalario}, depois de R$:{aumento} de aumento");

        }
        public void CalcularAlimentacao()
        {
            Console.WriteLine("Qual o valor do seu vale alimentação");
            double vale = Convert.ToDouble(Console.ReadLine());
            double desconto;
            if (vale > 250) {
                desconto = 0.05 * vale;
            }
            else if (vale > 250)
            {
                desconto = 0.02 * vale;
            }
            else
            {
                desconto = 0.01 * vale;
            }
            Console.WriteLine("DESCONTO:" + desconto);
        }
    }
}
