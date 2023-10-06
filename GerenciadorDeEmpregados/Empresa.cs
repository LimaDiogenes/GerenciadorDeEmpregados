using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GerenciadorDeEmpregados
{
    static internal class Empresa // classe estática pq apenas 1 objeto é necessário, serve para manter a lista de empregados.
    {
        private static List<Empregado> empregados;

        // inicializa lista de empregados quando a classe é acessada a primeira vez
        static Empresa()
        {
            empregados = new List<Empregado>();

            // teste

            Empregado empregado1 = new Empregado(1, "João", "Silva", 30, new DateOnly(1993, 5, 15), new DateOnly(2021, 3, 10), 3000.00);
            Empregado empregado2 = new Empregado(2, "Maria", "Santos", 28, new DateOnly(1995, 9, 22), new DateOnly(2020, 7, 5), 2800.00);
            Empregado empregado3 = new Empregado(3, "Carlos", "Oliveira", 35, new DateOnly(1988, 11, 8), new DateOnly(2019, 1, 18), 3500.00);
            Empregado empregado4 = new Empregado(4, "Ana", "Costa", 26, new DateOnly(1997, 4, 30), new DateOnly(2022, 8, 20), 400.00);
            Empregado empregado5 = new Empregado(5, "Paulo", "Pereira", 32, new DateOnly(1991, 8, 12), new DateOnly(2021, 2, 5), 3200.00);
            Empregado empregado6 = new Empregado(6, "Luiza", "Rodrigues", 29, new DateOnly(1994, 3, 25), new DateOnly(2020, 6, 15), 2900.00);
            Empregado empregado7 = new Empregado(7, "Marcos", "Ferreira", 33, new DateOnly(1990, 6, 7), new DateOnly(2018, 12, 12), 1200.00);
            Empregado empregado8 = new Empregado(8, "Mariana", "Gomes", 27, new DateOnly(1996, 10, 18), new DateOnly(2023, 1, 30), 2700.00);
            Empregado empregado9 = new Empregado(9, "Lucas", "Almeida", 31, new DateOnly(1992, 2, 28), new DateOnly(2022, 5, 8), 3100.00);
            Empregado empregado10 = new Empregado(10, "Camila", "Machado", 25, new DateOnly(1998, 7, 14), new DateOnly(2019, 11, 25), 2500.00);
            Empregado empregado11 = new Empregado(11, "Felipe", "Sousa", 34, new DateOnly(1989, 12, 4), new DateOnly(2020, 4, 15), 3400.00);
            Empregado empregado12 = new Empregado(12, "Amanda", "Rocha", 28, new DateOnly(1995, 9, 1), new DateOnly(2022, 7, 10), 295.00);
            Empregado empregado13 = new Empregado(13, "Gustavo", "Lima", 29, new DateOnly(1994, 2, 9), new DateOnly(2021, 9, 20), 2900.00);
            Empregado empregado14 = new Empregado(14, "Larissa", "Fernandes", 27, new DateOnly(1996, 6, 22), new DateOnly(2020, 12, 5), 2700.00);
            Empregado empregado15 = new Empregado(15, "Rodrigo", "Martins", 32, new DateOnly(1991, 10, 11), new DateOnly(2023, 2, 28), 3200.00);

            Cadastrar(empregado1);
            Cadastrar(empregado2);
            Cadastrar(empregado3);
            Cadastrar(empregado4);
            Cadastrar(empregado5);
            Cadastrar(empregado6);
            Cadastrar(empregado7);
            Cadastrar(empregado8);
            Cadastrar(empregado9);
            Cadastrar(empregado10);
            Cadastrar(empregado11);
            Cadastrar(empregado12);
            Cadastrar(empregado13);
            Cadastrar(empregado14);
            Cadastrar(empregado15);               

        }

        static internal void Cadastrar(Empregado empregado)
        {
            empregados.Add(empregado);
        }
        //private static void Promover(Empregado.Nome, Empregado.Sobrenome)
        //{
        //    return;
        //}
        //private static void Demitir(Empregado.Nome, Empregado.Sobrenome)
        //{
        //    return;
        //}

        static internal void ConsultarEmpregados()
        {
            
            int NumeroFunc = empregados.Count;
            int indice1 = 0;
            int indice2 = 1;
            int indice3 = 2;
            int indice4 = 3;
            int indice5 = 4;
            int indice6 = 5;

            try
            {
                Menu telaConsulta = new();
                labelInicioConsulta:
                telaConsulta.Linha1 = $"Relatório de Funcionários. Quantidade de pessoas cadastradas: {NumeroFunc}";
                telaConsulta.Linha2 = "=================================================================================";
                telaConsulta.Linha3 = $"Matrícula: {empregados[indice1].Matricula}, Nome: {empregados[indice1].Nome} {empregados[indice1].Sobrenome}, Nascimento: {empregados[indice1].DataNascimento}";
                telaConsulta.Linha4 = $"Idade: {empregados[indice1].Idade} anos, Salário: {empregados[indice1].Salario}, Contratação: {empregados[indice1].DataContratacao}";
                telaConsulta.Linha5 = telaConsulta.Linha2;
                if (NumeroFunc >= 2) // se a lista tiver 2 funcionarios ou mais, essas linhas são geradas
                {
                    telaConsulta.Linha6 = $"Matrícula: {empregados[indice2].Matricula}, Nome: {empregados[indice2].Nome} {empregados[indice2].Sobrenome}, Nascimento: {empregados[indice2].DataNascimento}";
                    telaConsulta.Linha7 = $"Idade: {empregados[indice2].Idade} anos, Salário: {empregados[indice2].Salario}, Contratação: {empregados[indice2].DataContratacao}";
                    telaConsulta.Linha8 = telaConsulta.Linha2;
                }
                if (NumeroFunc >= 3)
                {
                    telaConsulta.Linha10 = $"Matrícula: {empregados[indice3].Matricula}, Nome: {empregados[indice3].Nome} {empregados[indice3].Sobrenome}, Nascimento: {empregados[indice3].DataNascimento}";
                    telaConsulta.Linha11 = $"Idade: {empregados[indice3].Idade} anos, Salário: {empregados[indice3].Salario}, Contratação: {empregados[indice3].DataContratacao}";
                    telaConsulta.Linha12 = telaConsulta.Linha2;
                }
                if (NumeroFunc >= 3)
                {
                    telaConsulta.Linha13 = $"Matrícula: {empregados[indice4].Matricula}, Nome: {empregados[indice4].Nome} {empregados[indice4].Sobrenome}, Nascimento: {empregados[indice4].DataNascimento}";
                    telaConsulta.Linha14 = $"Idade: {empregados[indice4].Idade} anos, Salário: {empregados[indice4].Salario}, Contratação: {empregados[indice4].DataContratacao}";
                    telaConsulta.Linha15 = telaConsulta.Linha2;
                }
                if (NumeroFunc >= 4)
                {
                    telaConsulta.Linha17 = $"Matrícula: {empregados[indice5].Matricula}, Nome: {empregados[indice5].Nome} {empregados[indice5].Sobrenome}, Nascimento: {empregados[indice5].DataNascimento}";
                    telaConsulta.Linha18 = $"Idade: {empregados[indice5].Idade} anos, Salário: {empregados[indice5].Salario}, Contratação: {empregados[indice5].DataContratacao}";
                    telaConsulta.Linha19 = telaConsulta.Linha2;
                }

                if (NumeroFunc >= 5)
                {
                    telaConsulta.Linha21 = $"Matrícula: {empregados[indice6].Matricula}, Nome: {empregados[indice6].Nome} {empregados[indice6].Sobrenome}, Nascimento: {empregados[indice6].DataNascimento}";
                    telaConsulta.Linha22 = $"Idade: {empregados[indice6].Idade} anos, Salário: {empregados[indice6].Salario}, Contratação: {empregados[indice6].DataContratacao}";
                    telaConsulta.Linha23 = telaConsulta.Linha2;
                }
                telaConsulta.Linha24 = "[ ]";
                telaConsulta.Linha25 = "[D] DESCER LISTA     |     [Q] SAIR     |     [S] SUBIR LISTA";

                telaConsulta.ImprimirMenuVoid(52, 24);
                char opcao = char.ToUpper(Console.ReadKey().KeyChar);

                if (opcao == 'D') // adiciona 1 aos indices, para "rolar a tela" para baixo
                {
                    if (indice6 < (NumeroFunc-1))
                    {
                        indice1++; indice2++; indice3++; indice4++; indice5++; indice6++;
                    }
                    goto labelInicioConsulta;
                }
                else if (opcao == 'S') // Oposto da de cima. Retorna ao começo da tela para recomeçar a impressão
                {
                    if (indice1 > 0)
                    {
                        indice1--; indice2--; indice3--; indice4--; indice5--; indice6--;
                    }
                    goto labelInicioConsulta;
                }
                else if (opcao == 'Q') // Sair
                {
                    return;
                }
                else
                {
                    goto labelInicioConsulta; // mantem tela ativa caso outra tecla seja apertada, retornando ao inicio 
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Menu consultar = new();
                consultar.Linha1 = "Relatório de Funcionários";
                consultar.Linha4 = "=================================================================================";
                consultar.Linha5 = "Não há empregados cadastrados!";
                consultar.Linha6 = consultar.Linha4;
                consultar.Linha20 = "Aperte qualquer tecla para sair!";
                consultar.ImprimirMenuVoid(52, 2);

            }


        }
    }
}

