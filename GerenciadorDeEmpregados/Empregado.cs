using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeEmpregados
{
    internal class Empregado
    {
        internal int Matricula { get; set; }
        internal string Nome { get; set; }
        internal string Sobrenome { get; set; }
        internal int Idade { get; set; }
        internal DateOnly DataNascimento { get; set; }
        internal DateOnly DataContratacao { get; set; }
        
        internal double salario = 1320.00d; // valor do salario minimo
        internal double Salario
        {
            get
            { return salario; }
            set // checando para permitir atribuir o novo valor apenas se for >= ao minimo
            {
                if (value < salario)
                {
                    salario = 1320.00d;
                }
                salario = value; // else {}
            }
        }


        // construtor1 - dados completos
        internal Empregado(int matricula, string nome, string sobrenome, int idade, DateOnly dataNascimento, DateOnly dataContratacao, double salario)
        {
            Matricula = matricula;
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
            DataNascimento = dataNascimento;
            DataContratacao = dataContratacao;
            Salario = salario;
        }

        //construtor2 - dados basicos
        internal Empregado(string nome, string sobrenome, int idade, DateOnly dataNascimento)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
            DataNascimento = dataNascimento;
        }


        private double SalarioAnual() // Calcula o salário anual multiplicando o salário mensal por 12
        {
            return Salario * 12;
        }


    }
}
