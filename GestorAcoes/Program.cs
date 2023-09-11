// See https://aka.ms/new-console-template for more information
using GestorAcoes.Model;
using GestorAcoes.Model;

class Program
{
    // See https://aka.ms/new-console-template for more information

    static void Main()
    {
        CarteiraAcao carteira = new CarteiraAcao();
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Cadastro de ação");
            Console.WriteLine("2. Pesquisar por ação");
            Console.WriteLine("3. Visualizar a carteira de ações");
            Console.WriteLine("4. Limpar tela");
            Console.WriteLine("5. Sair");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    carteira.visualizarAcoesDisponiveis();
                    Console.Write("Informe o código da ação: ");
                    string codigo = Console.ReadLine();
                    Console.Write("Informe a quantidade de ações: ");
                    int quantidade = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    carteira.cadastrarAcao(codigo, quantidade);
                    break;
                case 2:
                    Console.Write("Informe o código da ação a ser pesquisada: ");
                    string codigoPesquisa = Console.ReadLine();
                    carteira.pesquisarAcao(codigoPesquisa);
                    break;
                case 3:
                    carteira.visualizarCarteira();
                    break;
                case 4:
                    Console.Clear();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

}
