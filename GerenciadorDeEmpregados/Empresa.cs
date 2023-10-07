namespace GerenciadorDeEmpregados
{
    static internal class Empresa // classe estática pq apenas 1 objeto é necessário, serve para manter a lista de empregados.
    {
        internal static List<Empregado> empregados { get; private set; } // lista com todos os empregados
        internal static List<int> matriculas { get; private set; } // lista com todas as matrículas

        // inicializa lista de empregados quando a classe é acessada a primeira vez
        static Empresa()
        {
            empregados = new List<Empregado>();
            matriculas = new List<int>();

            // teste - retirar depois de implantar BD externo

            Empregado empregado1 = new Empregado("Joao", "Silva", new DateOnly(1993, 5, 15), new DateOnly(2021, 3, 10), 3000.00);
            Cadastrar(empregado1);
            Empregado empregado2 = new Empregado("Maria", "Santos", new DateOnly(1995, 9, 22), new DateOnly(2020, 7, 5), 2800.00);
            Cadastrar(empregado2);
            Empregado empregado3 = new Empregado("Carlos", "Oliveira", new DateOnly(1988, 11, 8), new DateOnly(2019, 1, 18), 3500.00);
            Cadastrar(empregado3);
            Empregado empregado4 = new Empregado("Ana", "Costa", new DateOnly(1997, 4, 30), new DateOnly(2022, 8, 20), 400.00);
            Cadastrar(empregado4);
            Empregado empregado5 = new Empregado("Paulo", "Pereira", new DateOnly(1991, 8, 12), new DateOnly(2021, 2, 5), 3200.00);
            Cadastrar(empregado5);
            Empregado empregado6 = new Empregado("Luiza", "Rodrigues", new DateOnly(1994, 3, 25), new DateOnly(2020, 6, 15), 2900.00);
            Cadastrar(empregado6);
            Empregado empregado7 = new Empregado("Marcos", "Ferreira", new DateOnly(1990, 6, 7), new DateOnly(2018, 12, 12), 1200.00);
            Cadastrar(empregado7);
            Empregado empregado8 = new Empregado("Mariana", "Gomes", new DateOnly(1996, 10, 18), new DateOnly(2023, 1, 30), 2700.00);
            Cadastrar(empregado8);
            Empregado empregado9 = new Empregado("Lucas", "Almeida", new DateOnly(1992, 2, 28), new DateOnly(2022, 5, 8), 3100.00);
            Cadastrar(empregado9);
            Empregado empregado10 = new Empregado("Camila", "Machado", new DateOnly(1998, 7, 14), new DateOnly(2019, 11, 25), 2500.00);
            Cadastrar(empregado10);
            Empregado empregado11 = new Empregado("Felipe", "Sousa", new DateOnly(1989, 12, 4), new DateOnly(2020, 4, 15), 3400.00);
            Cadastrar(empregado11);
            Empregado empregado12 = new Empregado("Amanda", "Rocha", new DateOnly(1995, 9, 1), new DateOnly(2022, 7, 10), 295.00);
            Cadastrar(empregado12);
            Empregado empregado13 = new Empregado("Gustavo", "Lima", new DateOnly(1994, 2, 9), new DateOnly(2021, 9, 20), 2900.00);
            Cadastrar(empregado13);
            Empregado empregado14 = new Empregado("Larissa", "Fernandes", new DateOnly(1996, 6, 22), new DateOnly(2020, 12, 5), 2700.00);
            Cadastrar(empregado14);
            Empregado empregado15 = new Empregado("Rodrigo", "Martins", new DateOnly(1991, 10, 11), new DateOnly(2023, 2, 28), 3200.00);
            Cadastrar(empregado15);

        }

        static internal void Cadastrar(Empregado empregado)
        {
            empregados.Add(empregado);
        }

        internal static double Promover(Empregado empregado) // nesse caso, como não existe função no programa, promover apenas aumenta o salário
        {
            double porcentagem = (empregado.salario / 100) * 10; // calcula 10% do salario
            empregado.salario = empregado.salario + porcentagem;
            return empregado.Salario;
        }

        internal static void Demitir(Empregado empregado)
        {
            matriculas.Remove(empregado.Matricula); // remove a matricula da lista
            empregados.Remove(empregado); //  remove o objeto da lista
            
        }

        static internal int GerarMatricula() // chamar no construtor do Empregado
        {            
            foreach (Empregado empregado in empregados)
            {                
                if (matriculas.Contains(empregado.Matricula)) // checa se a matricula ja existe na lista
                {
                    continue;
                }
                else
                {
                    matriculas.Add(empregado.Matricula); // adiciona novamente as matrículas da lista
                }
                
            }
            int novaMatricula = 1;
            while (true)
            {
                if (matriculas.Contains(novaMatricula)) // checa se a matrícula já existe na lista
                {
                    novaMatricula++; // se já existir, adiciona 1 e segue no loop, até encontrar o primeiro número não usado
                }
                else
                {
                    return novaMatricula;
                }
            }
        }

        //static internal void ListarEmpregados()
        //{

        //    List<Empregado> empregadosOrdenados = empregados.OrderBy(empregado => empregado.Matricula).ToList(); // cria uma nova lista ordenada por matriculas
        //    int NumeroFunc = empregadosOrdenados.Count;
        //    int indice1 = 0;
        //    int indice2 = 1;
        //    int indice3 = 2;
        //    int indice4 = 3;
        //    int indice5 = 4;
        //    int indice6 = 5;

        //    try
        //    {
        //        Menu telaConsulta = new();
        //    labelInicioConsulta:
        //        telaConsulta.Linha1 = $"Relatório de Funcionários. Quantidade de pessoas cadastradas: {NumeroFunc}";
        //        telaConsulta.Linha2 = "=================================================================================";
        //        telaConsulta.Linha3 = $"Matrícula: {empregadosOrdenados[indice1].Matricula}, Nome: {empregadosOrdenados[indice1].Nome} {empregadosOrdenados[indice1].Sobrenome}, Nascimento: {empregadosOrdenados[indice1].DataNascimento}";
        //        telaConsulta.Linha4 = $"Idade: {empregadosOrdenados[indice1].Idade} anos, Salário: {empregadosOrdenados[indice1].Salario}, Contratação: {empregadosOrdenados[indice1].DataContratacao}";
        //        telaConsulta.Linha5 = telaConsulta.Linha2;
        //        if (NumeroFunc >= 2) // se a lista tiver 2 funcionarios ou mais, essas linhas são geradas
        //        {
        //            telaConsulta.Linha6 = $"Matrícula: {empregadosOrdenados[indice2].Matricula}, Nome: {empregadosOrdenados[indice2].Nome} {empregadosOrdenados[indice2].Sobrenome}, Nascimento: {empregadosOrdenados[indice2].DataNascimento}";
        //            telaConsulta.Linha7 = $"Idade: {empregadosOrdenados[indice2].Idade} anos, Salário: {empregadosOrdenados[indice2].Salario}, Contratação: {empregadosOrdenados[indice2].DataContratacao}";
        //            telaConsulta.Linha8 = telaConsulta.Linha2;
        //        }
        //        if (NumeroFunc >= 3)
        //        {
        //            telaConsulta.Linha10 = $"Matrícula: {empregadosOrdenados[indice3].Matricula}, Nome: {empregadosOrdenados[indice3].Nome} {empregadosOrdenados[indice3].Sobrenome}, Nascimento: {empregadosOrdenados[indice3].DataNascimento}";
        //            telaConsulta.Linha11 = $"Idade: {empregadosOrdenados[indice3].Idade} anos, Salário: {empregadosOrdenados[indice3].Salario}, Contratação: {empregadosOrdenados[indice3].DataContratacao}";
        //            telaConsulta.Linha12 = telaConsulta.Linha2;
        //        }
        //        if (NumeroFunc >= 3)
        //        {
        //            telaConsulta.Linha13 = $"Matrícula: {empregadosOrdenados[indice4].Matricula}, Nome: {empregadosOrdenados[indice4].Nome} {empregadosOrdenados[indice4].Sobrenome}, Nascimento: {empregadosOrdenados[indice4].DataNascimento}";
        //            telaConsulta.Linha14 = $"Idade: {empregadosOrdenados[indice4].Idade} anos, Salário: {empregadosOrdenados[indice4].Salario}, Contratação: {empregadosOrdenados[indice4].DataContratacao}";
        //            telaConsulta.Linha15 = telaConsulta.Linha2;
        //        }
        //        if (NumeroFunc >= 4)
        //        {
        //            telaConsulta.Linha17 = $"Matrícula: {empregadosOrdenados[indice5].Matricula}, Nome: {empregadosOrdenados[indice5].Nome} {empregadosOrdenados[indice5].Sobrenome}, Nascimento: {empregadosOrdenados[indice5].DataNascimento}";
        //            telaConsulta.Linha18 = $"Idade: {empregadosOrdenados[indice5].Idade} anos, Salário: {empregadosOrdenados[indice5].Salario}, Contratação: {empregadosOrdenados[indice5].DataContratacao}";
        //            telaConsulta.Linha19 = telaConsulta.Linha2;
        //        }

        //        if (NumeroFunc >= 5)
        //        {
        //            telaConsulta.Linha21 = $"Matrícula: {empregadosOrdenados[indice6].Matricula}, Nome: {empregadosOrdenados[indice6].Nome} {empregadosOrdenados[indice6].Sobrenome}, Nascimento: {empregadosOrdenados[indice6].DataNascimento}";
        //            telaConsulta.Linha22 = $"Idade: {empregadosOrdenados[indice6].Idade} anos, Salário: {empregadosOrdenados[indice6].Salario}, Contratação: {empregadosOrdenados[indice6].DataContratacao}";
        //            telaConsulta.Linha23 = telaConsulta.Linha2;
        //        }
        //        telaConsulta.Linha24 = "[ ]";
        //        telaConsulta.Linha25 = "[D] DESCER LISTA     |     [Q] SAIR     |     [S] SUBIR LISTA";

        //        telaConsulta.ImprimirMenuVoid(52, 24);
        //        char opcao = char.ToUpper(Console.ReadKey().KeyChar);

        //        if (opcao == 'D') // adiciona 1 aos indices, para "rolar a tela" para baixo
        //        {
        //            if (indice6 < (NumeroFunc - 1))
        //            {
        //                indice1++; indice2++; indice3++; indice4++; indice5++; indice6++;
        //            }
        //            goto labelInicioConsulta;
        //        }
        //        else if (opcao == 'S') // Oposto da de cima. Retorna ao começo da tela para recomeçar a impressão
        //        {
        //            if (indice1 > 0)
        //            {
        //                indice1--; indice2--; indice3--; indice4--; indice5--; indice6--;
        //            }
        //            goto labelInicioConsulta;
        //        }
        //        else if (opcao == 'Q') // Sair
        //        {
        //            return;
        //        }
        //        else
        //        {
        //            goto labelInicioConsulta; // mantem tela ativa caso outra tecla seja apertada, retornando ao inicio 
        //        }
        //    }
        //    catch (ArgumentOutOfRangeException)
        //    {
        //        Menu consultar = new();
        //        consultar.Linha1 = "Relatório de Funcionários";
        //        consultar.Linha4 = "=================================================================================";
        //        consultar.Linha5 = "Não há empregados cadastrados!";
        //        consultar.Linha6 = consultar.Linha4;
        //        consultar.Linha20 = "Aperte qualquer tecla para sair!";
        //        consultar.ImprimirMenuVoid(52, 2);

        //    }


        //}
    }
}

