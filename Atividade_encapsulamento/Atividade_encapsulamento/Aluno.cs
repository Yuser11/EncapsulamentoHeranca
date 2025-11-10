using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_encapsulamento
{
    public class Aluno: Pessoa
    {
        private string ra;
        private string cpf;

        public string Ra { get { return ra; } set { ra = value; } }

        public void ApresentarAluno()
        {
            Console.WriteLine("NOME:" + nome);
            Console.WriteLine("COR:" + cor);
            Console.WriteLine("ALTURA:" + altura);
            Console.WriteLine("RA:" + ra);
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
            if (ra == "")
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
