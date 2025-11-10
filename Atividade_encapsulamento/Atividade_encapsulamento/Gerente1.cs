using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_encapsulamento
{
    internal class Gerente1 : Empregado
    {
        private string area;
        public string Area { get { return area; } set { area = value; } }

    }
}
