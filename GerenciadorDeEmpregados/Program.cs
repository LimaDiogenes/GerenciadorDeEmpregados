namespace GerenciadorDeEmpregados
{
    internal class Program
    {
        static void Main()
        {
            
            Menu telaInicial = new(); // cria a tela inicial (margens)
            bool manterLoop1 = true;
            while (manterLoop1)
            {                
                char OpcaoInicial = telaInicial.MenuInicial(); // chama menu inicial, recebe variavel da opcao

                switch (OpcaoInicial)
                {
                    case 'Q': // sair                        
                        Console.SetCursorPosition(52, 13);
                        Console.WriteLine("Adeus...");
                        Thread.Sleep(3000);
                        Console.SetCursorPosition(52, 27); // joga o cursor para fora da tela, para não cortar a tela antes de fechar
                        Environment.Exit(0);
                        break;

                    case 'C': // cadastrar
                        telaInicial.MenuCadastrar();                        
                        break;

                    case 'L': // listar empregados
                        Empresa.ListarEmpregados();
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
                        telaInicial.Linha24 = "Opção Inválida";
                        break;                        

                }                              
                
            }
        }
    }
}