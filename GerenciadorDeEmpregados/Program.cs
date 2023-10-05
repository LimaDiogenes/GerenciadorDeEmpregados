namespace GerenciadorDeEmpregados
{
    internal class Program
    {
        static void Main()
        {while (true)
            {
                Menu telaInicial = new(); // cria a tela inicial (loop para manter ativo o tempo todo)
                
                char OpcaoInicial = telaInicial.MenuInicial();
                


                Console.WriteLine(OpcaoInicial);
                Console.ReadLine();
            }



        }
    }
}