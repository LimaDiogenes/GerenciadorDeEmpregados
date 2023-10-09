using System.Reflection;

namespace GerenciadorDeEmpregados
{
    internal static class BaseDados
    {
        private static List<Empregado> bd { get; set; }
        /// <summary>
        /// Faz os preparativos estruturais para inserir a Base De Dados no sitema
        /// </summary>
        internal static void Inicializar()
        {
            bd = new(); // inicializa a lista banco de dados (bd)
            Ler(); // le o arquivo externo
            foreach (Empregado empregado in bd)
            {
                Empresa.empregados.Add(empregado); // passa os empregados lidos para a lista usada durante a execucao do programa
            }
        }
        /// <summary>
        /// Le a Data Base externa e a incorpora no sistema
        /// </summary>
        internal static void Ler() 
        {
            try // tenta encontrar o arquivo da base de dados na pasta \bin\debug\net6.0
            {
                string arquivo = BuscarCaminho(); 
                using (StreamReader leitor = new StreamReader(arquivo))  //StreamReader le linhas do arquivo csv no argumento
                {
                    string linha;                    

                    while ((linha = leitor.ReadLine()) != null) // retorno do leitor é passado para linha, enquanto a linha não for vazia:
                    {
                        //char separador = ';';
                        string[] e = linha.Split(';'); //split retorna uma array com os valores encontrados. e0=matricula, e1=nome, e2=sobrenome, e3=nascimento, e4=contratacao, e5=idade???, e6=salario
                        Empregado empregado = new(e[1], e[2], DateOnly.Parse(e[3]), DateOnly.Parse(e[4]), double.Parse(e[6]));
                        empregado.InfoBD(int.Parse(e[0]));
                        bd.Add(empregado); // valores retornados da array, que devem ser respectivamente, palavra e dica
                    }
                }
            }
            catch (Exception)
            {
                Menu erro = new();
                erro.NaoEncontrado();                
            }
        }
        /// <summary>
        /// Grava novo empregado na Base De DAdos
        /// </summary>
        internal static void Gravar()
        {
            bd.Clear(); // limpa a bd antes de adicionar todos novamente. Serve para n\ao duplocar valores.
            foreach (Empregado empregado in Empresa.empregados) // adiciona os empregados da lista da classe Empresa ao bd
            {
                bd.Add(empregado);
            }
            List<Empregado> bdOrdenado = bd.OrderBy(empregado => empregado.Matricula).ToList();
            {
                string arquivo = BuscarCaminho(); // path está recebendo o caminho do csv. Sobreescreve o arquivo sempre que é chamado.
                using (var gravar = new StreamWriter(arquivo))  //StreamWriter escreve linha por linha no csv que está no argumento
                {
                    foreach (Empregado e in bdOrdenado) // para cada empregado(e) na base de dados (bdOrdenado)
                    {
                        gravar.WriteLine("{0};{1};{2};{3};{4};{5};{6};", e.Matricula, e.Nome, e.Sobrenome, e.DataNascimento, e.DataContratacao, e.Idade, e.Salario); // Gravar é o objeto criado acima, que aqui escreve os dados separados por ; no arquivo csv
                    }
                }
            }

        }
        /// <summary>
        /// verifica o diretorio onde o programa esta instalado
        /// </summary>
        /// <returns></returns>
        internal static string BuscarCaminho() 
        {
            // Busca o diretório de onde o programa está sendo executado. 
            // como funciona, apenas que está retornando uma string com o diretorio raiz do programa
            string caminho = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location); // usando blblioteca system.reflections para retornar a localização do programa

            // Combinando o diretorio retornado acima com o nome do arquivo csv
            string endereco = Path.Combine(caminho, "csvDatabase.csv");

            // retorno contendo o caminho + nome do arquivo
            return (endereco);

        }
    }
}


