namespace GerenciadorDeEmpregados
{
    static internal class Empresa // classe estática pq apenas 1 objeto é necessário, serve para manter a lista de empregados.
    {
        internal static List<Empregado> empregados { get; private set; } // lista com todos os empregados
        internal static List<int> matriculas { get; private set; } // lista com todas as matrículas

        /// <summary>
        /// inicializa lista de empregados quando a classe é acessada a primeira vez
        /// </summary>
        static Empresa()
        {            
            empregados = new List<Empregado>();
            matriculas = new List<int>();
        }
        /// <summary>
        /// armazena um novo Empregado na lista e na Base De Dados
        /// </summary>
        /// <param name="empregado"></param>
        static internal void Cadastrar(Empregado empregado)
        {
            empregados.Add(empregado);
            BaseDados.Gravar();
        }
        /// <summary>
        /// Aumenta o salario do Empregado passado nos parametros em 10%
        /// </summary>
        /// <param name="empregado"></param>
        /// <returns></returns>
        internal static double Promover(Empregado empregado)
        {
            double porcentagem = (empregado.salario / 10); // calcula 10% do salario
            empregado.salario = empregado.salario + porcentagem;
            BaseDados.Gravar();
            return empregado.Salario;            
        }
        /// <summary>
        /// Remove Empregado da lista e da Base De Dados
        /// </summary>
        /// <param name="empregado"></param>
        internal static void Demitir(Empregado empregado)
        {
            matriculas.Remove(empregado.Matricula); // remove a matricula da lista
            empregados.Remove(empregado); //  remove o objeto da lista
            BaseDados.Gravar();
        }
        /// <summary>
        /// Gera nova matricula valida para novo Empregado
        /// </summary>
        /// <returns></returns>
        static internal int GerarMatricula() // chamar no construtor do Empregado
        {
            foreach (Empregado empregado in empregados)
            {
                if (!matriculas.Contains(empregado.Matricula)) // checa se a matricula ja existe na lista
                {
                    matriculas.Add(empregado.Matricula);
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

