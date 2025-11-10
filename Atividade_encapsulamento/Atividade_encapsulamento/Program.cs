using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Atividade_encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa()
            {
                nome = "yuri",
                idade = 19,
                cor = "branco",
                altura = 1.80,

                CPF = "3132131",
                RG = "43434343",
                Cidade = "fernão",
                Estado = "garca"
            };
            pessoa.ApresentarPessoa();



            Empregado empregado = new Empregado()
            {
                nome = "yuri",
                idade = 19,

                CPF = "3132131",
                RG = "43434343",

                Departarmento = "usinagem",
                Salario = 3000.50,
                setor = "3"
                
            };
            empregado.CalcularSalario(3000);
            empregado.CalcularAlimentacao();


            Gerente1 gerente1 = new Gerente1()
            {
                nome = "yuri",
                idade = 19,

                CPF = "3132131",
                RG = "43434343",

                Departarmento = "usinagem",
                Salario = 3000.50,
                setor = "3",
                Area = "AREA DO GERENTE"
            };
            Console.WriteLine("NOME:" + gerente1.nome);
            Console.WriteLine("IDADE:" + gerente1.idade);
            Console.WriteLine("CPF:" + gerente1.CPF);

            Console.WriteLine("RG:" + gerente1.RG);
            Console.WriteLine("SALÁRIO:" + gerente1.Salario);
            Console.WriteLine("SETOR:" + gerente1.setor);
            Console.WriteLine("DEPARTAMENTO:" + gerente1.Departarmento);
            Console.WriteLine("ÁREA:" + gerente1.Area);

        }
    }
}
