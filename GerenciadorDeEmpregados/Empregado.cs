using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeEmpregados
{
    internal class Empregado
    {
        private int Matricula { get; set; }
        private string Nome { get; set; }
        private string Sobrenome { get; set; }
        private int Idade { get; set; }
        private DateOnly DataNascimento { get; set; }
        private DateTime DataContratacao { get; set; }

        private double Salario { get; set; }


    }
}
