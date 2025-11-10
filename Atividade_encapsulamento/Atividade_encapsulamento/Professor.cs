using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_encapsulamento
{
    internal class Professor: Pessoa
    {
        private string nif;
        private string cpf;



        public void ApresentarProfessor()
        {
            Console.WriteLine("NOME:" + nome);
            Console.WriteLine("IDADE:" + idade);
            Console.WriteLine("COR:" + cor);
            Console.WriteLine("ALTURA:" + altura);

            Console.WriteLine("NIF:" + nif);
            Console.WriteLine("CPF:" + cpf);
        }
        public override int ValidarCampos()
        {
            if (!(idade > 0))
            {
                return 1;
            }
            if (!(altura > 0))
            {
                return 2;
            }
            if (cpf == "")
            {
                return 3;
            }
            if (nif == "")
            {
                return 4;
            }
            else
            {
                return 0;
            }
        }
    }
}
