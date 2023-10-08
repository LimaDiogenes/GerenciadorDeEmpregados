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
        }

        static internal void Cadastrar(Empregado empregado)
        {
            empregados.Add(empregado);
            BaseDados.Gravar();
        }

        internal static double Promover(Empregado empregado) // nesse caso, como não existe função no programa, promover apenas aumenta o salário
        {
            double porcentagem = (empregado.salario / 100) * 10; // calcula 10% do salario
            empregado.salario = empregado.salario + porcentagem;
            BaseDados.Gravar();
            return empregado.Salario;            
        }

        internal static void Demitir(Empregado empregado)
        {
            matriculas.Remove(empregado.Matricula); // remove a matricula da lista
            empregados.Remove(empregado); //  remove o objeto da lista
            BaseDados.Gravar();
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
                if (matriculas.Contains(novaMatricula)) // checa se a nova matrícula já existe na lista
                {
                    novaMatricula++; // se já existir, adiciona 1 e segue no loop, até encontrar o primeiro número não usado
                }
                else
                {
                    return novaMatricula;
                }
            }
        }
    }
}

