namespace GerenciadorDeEmpregados
{
    internal class Program
    {
        static void Main()
        {
            Empresa empresa = new Empresa(); // cria objeto Empresa. Objeto inicializa uma nova lista
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
                        Console.ReadLine();
                        Console.SetCursorPosition(52, 27); // joga o cursor para fora da tela, para não cortar a tela antes de fechar
                        Environment.Exit(0);
                        break;

                    case 'C': // cadastrar
                        telaInicial.MenuCadastrar();
                        Console.ReadLine();
                        break;

                    case 'L': // listar empregados
                        Console.WriteLine();
                        Console.WriteLine(OpcaoInicial+" placeholder listar");
                        Console.ReadLine();
                        break;

                    case 'P': // promover empregado
                        Console.WriteLine();
                        Console.WriteLine(OpcaoInicial + " placeholder promover");
                        Console.ReadLine();
                        break;

                    case 'D': // demitir empregado
                        Console.WriteLine();
                        Console.WriteLine(OpcaoInicial + " placeholder demitir");
                        Console.ReadLine();
                        break;
                    
                    case 'S': // listar salário anual
                        Console.WriteLine();
                        Console.WriteLine(OpcaoInicial + " placeholder salario anual");
                        Console.ReadLine();
                        break;

                    default:
                        telaInicial.Linha24 = "Opção Inválida";
                        break;
                        

                }                              
                
            }
        }
    }
}