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

        private double salario = 1320.00d; // valor do salario minimo
        private double Salario
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
        internal Empregado(int matricula, string nome, string sobrenome, int idade, DateOnly dataNascimento, DateTime dataContratacao, double salario)
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
