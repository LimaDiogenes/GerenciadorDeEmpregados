using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeEmpregados
{
    internal class Menu
    {
        internal string Linha1 { get; set; } = "";
        internal string Linha2 { get; set; } = "";
        internal string Linha3 { get; set; }   = "";
        internal string Linha4 { get; set; }   = "";
        internal string Linha5 { get; set; }   = "";
        internal string Linha6 { get; set; }   = "";
        internal string Linha7 { get; set; }   = "";
        internal string Linha8 { get; set; }   = "";
        internal string Linha9 { get; set; }   = "";
        internal string Linha10 { get; set; }  = "";
        internal string Linha11 { get; set; }  = "";
        internal string Linha12 { get; set; }  = "";
        internal string Linha13 { get; set; }  = "";
        internal string Linha14 { get; set; }  = "";
        internal string Linha15 { get; set; }  = "";
        internal string Linha16 { get; set; }  = "";
        internal string Linha17 { get; set; }  = "";
        internal string Linha18 { get; set; }  = "";
        internal string Linha19 { get; set; }  = "";
        internal string Linha20 { get; set; }  = "";
        internal string Linha21 { get; set; }  = "";
        internal string Linha22 { get; set; }  = "";
        internal string Linha23 { get; set; }  = "";
        internal string Linha24 { get; set; }  = "";
        internal string Linha25 { get; set; }  = "";

        internal char MenuInicial() // cria menu com as opcoes iniciais
        {
            Linha3 = "Gerenciador de Empregados";
            Linha7 = "════════════════════════════════════════════════════════════════════════════════════════════════";
            Linha10 = "Escolha uma opção abaixo";
            Linha15 = "[ ]";
            Linha17 = Linha7;
            Linha20 = "[C] Cadastrar empregado       [L] Listar empregados";
            Linha21 = "[P] Promover empregado        [D] Demitir Empregado";
            Linha22 = "[S] Listar salário anual      [Q] Encerrar programa";

            return MenuRetornaChar(52, 15); // usa este metodo para substituir as linhas, posicionar o cursor, e retornar a opcao do usuario
        }

        internal Menu() // construtor chama tela inicial, em branco, cria margens da tela
        {
            Console.Clear();
            TextoCentralizado("", starter: '╔', sep: '═', ends: '╗');
            TextoCentralizado("");
            TextoCentralizado("");
            TextoCentralizado("");
            TextoCentralizado("");
            TextoCentralizado("");
            TextoCentralizado("");
            TextoCentralizado("");
            TextoCentralizado("");
            TextoCentralizado("");
            TextoCentralizado("");
            TextoCentralizado("");
            TextoCentralizado("");
            TextoCentralizado("");
            TextoCentralizado("");
            TextoCentralizado("");
            TextoCentralizado("");
            TextoCentralizado("");
            TextoCentralizado("");
            TextoCentralizado("");
            TextoCentralizado("");
            TextoCentralizado("");
            TextoCentralizado("");
            TextoCentralizado("");
            TextoCentralizado("");
            TextoCentralizado("");
            TextoCentralizado("", starter: '╚', sep: '═', ends: '╝');
        }

        private char MenuRetornaChar(int posicaoX, int posicaoY) // substitui linhas pela informacao necessaria. Usar dentro da classe
        {
            Console.SetCursorPosition(0, 1);

            Console.WriteLine(
            SubstituirPalavras(Linha1) + "\n" +
            SubstituirPalavras(Linha2) + "\n" +
            SubstituirPalavras(Linha3) + "\n" +
            SubstituirPalavras(Linha4) + "\n" +
            SubstituirPalavras(Linha5) + "\n" +
            SubstituirPalavras(Linha6) + "\n" +
            SubstituirPalavras(Linha7) + "\n" +
            SubstituirPalavras(Linha8) + "\n" +
            SubstituirPalavras(Linha9) + "\n" +
            SubstituirPalavras(Linha10) + "\n" +
            SubstituirPalavras(Linha11) + "\n" +
            SubstituirPalavras(Linha12) + "\n" +
            SubstituirPalavras(Linha13) + "\n" +
            SubstituirPalavras(Linha14) + "\n" +
            SubstituirPalavras(Linha15) + "\n" +
            SubstituirPalavras(Linha16) + "\n" +
            SubstituirPalavras(Linha17) + "\n" +
            SubstituirPalavras(Linha18) + "\n" +
            SubstituirPalavras(Linha19) + "\n" +
            SubstituirPalavras(Linha20) + "\n" +
            SubstituirPalavras(Linha21) + "\n" +
            SubstituirPalavras(Linha22) + "\n" +
            SubstituirPalavras(Linha23) + "\n" +
            SubstituirPalavras(Linha24) + "\n" +
            SubstituirPalavras(Linha25));


            Console.SetCursorPosition(posicaoX, posicaoY); //posicionamento do cursor para input
            char OpcaoUsuario = char.ToUpper(Console.ReadKey().KeyChar); //variavel com a selecao do usuario. ReadKey aqui serve para receber a primeira tecla do input do usuario,
            //e KeyChar passa o valor recebido em formato ´char´para a variavel OpcaoUsuario

            return OpcaoUsuario;
        }

        /// <summary>       
        /// cria um texto centralizado, usado para montar a tela no console, aceitando como argumentos:
        /// 
        /// Todos os parâmetros são opcionais, e com valores padrão criam linhas com margem nas laterais
        /// Caracteres para usar como starter / ends / sep:{ ╔ ╗ ╚ ╝ ═ } Com estes é possível montar linhas do topo e do final
        /// Altura é controlada pelo número de linhas utilizado
        /// </summary>
        /// <param name="text">texto a ser exibido centralizado</param>
        /// <param name="starter">primeiro caractere da linha (margem)</param>
        /// <param name="ends">ultimo caractere da linha (margem)</param>
        /// <param name="sep">caracter para usar como separador, que aparecerá antes e depois do texto até o tamanho da tela</param>
        /// <param name="width">largura</param>                
        static void TextoCentralizado(string text = "", char starter = '║', char ends = '║', char sep = ' ', int width = 100)
        {
            int padWidth = (width - text.Length) / 2; // encontra a metade da largura, excluindo o tamanho do texto criado
            string paddedText = text.PadLeft(text.Length + padWidth, sep).PadRight(width, sep); // PadLeft e PadRight criam caracteres de preenchimento "sep" em ambos os lados do texto, deixando centralizado na tela  
            Console.WriteLine("  " + starter + paddedText + ends + "  "); // cria o texto centralizado na tela usando starter e ends como margem

        }

        // SubstituirPalavras é uma versão alterada de TextoCentralizado acima, retornando o que deve ser escrito
        // forma encontrada para poder utilizar como argumento, dentro de TextoCentralizado, assim podendo imprimir texto dentro das margens, sem apagá-las
        static string SubstituirPalavras(string text = "", char starter = '║', char ends = '║', char sep = ' ', int width = 100) // cria um texto centralizado, aceitando como argumentos "end = primeiro e ultimo caractere da linha", "sep = caracter para usar como separador, que aparecerá antes e depois do texto até o tamanho da tela", "width = largura" todos os parâmetros são opcionais
        {
            int padWidth = (width - text.Length) / 2; // encontra a metada da largura, excluindo o tamanho do texto criado
            string palavra = text.PadLeft(text.Length + padWidth, sep).PadRight(width, sep); // PadLeft e PadRight criam caracteres de preenchimento "sep" em ambos os lados do texto, deixando centralizado na tela  
            string replacer = ("  " + starter + palavra + ends + "  "); // cria o texto centralizado na tela usando os "ends" como margem
            return replacer;
        }


    }
}
