using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_encapsulamento
{
    public class Pessoa
    {
        public string nome;
        public int idade;
        public string cor;
        public double altura;

        private string rg;
        private string cpf;
        private string cidade;
        private string estado;

        public string RG { get { return rg; } set { rg = value; }}
        public string CPF { get { return cpf; } set { cpf = value; } }
        public string Cidade { get { return cidade; } set { cidade = value; } }
        public string Estado { get { return estado; } set { estado = value; } }

        public void ApresentarPessoa()
        {
            Console.WriteLine("NOME:" + nome);
            Console.WriteLine("IDADE:" + idade);
            Console.WriteLine("COR:" + cor);
            Console.WriteLine("ALTURA:"+ altura);

            Console.WriteLine("RG:" + rg);
            Console.WriteLine("CPF:" + cpf);
            Console.WriteLine("CIDADE:" + cidade);
            Console.WriteLine("ESTADO:" + estado);
        }
        public virtual int ValidarCampos()
        {
            if (!(idade > 0))
            {
                return 1;
            }
            if (!(altura > 0))
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
    }
}
