using System.Globalization;

namespace GerenciadorDeEmpregados
{
    internal class Program
    {
        static void Main()
        {
            CultureInfo cultura = new CultureInfo("pt-BR"); // ajustando cultura p/ br. Usar vírgula para separador de centavos, dd/mm/aaaa, etc...
            CultureInfo.DefaultThreadCurrentCulture = cultura;
            CultureInfo.DefaultThreadCurrentUICulture = cultura;

            BaseDados.Inicializar();
            Menu telaInicial = new(); // cria a tela inicial (margens)
            bool manterLoop1 = true;
            while (manterLoop1)
            {
                char OpcaoInicial = telaInicial.MenuInicial(); // chama menu inicial, recebe variavel da opcao

                switch (OpcaoInicial)
                {
                    case 'Q': // sair                        
                        Console.SetCursorPosition(48, 13);
                        Console.WriteLine("Adeus...");
                        Thread.Sleep(3000);
                        Console.SetCursorPosition(52, 27); // joga o cursor para fora da tela, para não cortar a tela antes de fechar
                        Environment.Exit(0);
                        break;

                    case 'C': // cadastrar
                        telaInicial.MenuCadastrar();
                        break;

                    case 'L': // listar empregados
                        Menu listar = new();
                        listar.MenuListarEmpregados();
                        break;

                    case 'P': // promover empregado
                        Menu promover = new();
                        promover.MenuPromover();
                        break;

                    case 'D': // demitir empregado
                        Menu demitir = new();
                        demitir.MenuDemitir();
                        break;

                    case 'S': // listar salário anual                      

                        Menu salario = new();
                        salario.MenuSalarioAnual();
                        break;

                    default:
                        break;

                }
            }
        }
    }
}