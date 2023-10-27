using Academia.Dotnet.POO.Exercicio03;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Corretora De Imóveis *****");

        CorretoraDeImoveis corretora = new CorretoraDeImoveis();

        while (true)
        {
            int opcao;

            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1. Inserir imóvel");
            Console.WriteLine("2. Alterar preço do imóvel");
            Console.WriteLine("3. Listar imóveis");
            Console.WriteLine("4. Calcular valor médio dos imóveis");
            Console.WriteLine("5. Sair");
            Console.Write("\nOpção Escolhida: ");


            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                continue;
            }

            switch (opcao)
            {
                case 1:
                    Console.Write("Endereço do imóvel: ");
                    string endereco = Console.ReadLine();
                    Console.Write("Preço do imóvel: ");
                    double preco = double.Parse(Console.ReadLine());
                    Console.Write("Tipo do imóvel: ");
                    string tipo = Console.ReadLine();
                    corretora.InserirImovel(endereco, preco, tipo);
                    break;

                case 2:
                    Console.Write("Endereço do imóvel a ser alterado: ");
                    string enderecoAlterar = Console.ReadLine();
                    Console.Write("Novo preço: ");
                    double novoPreco = double.Parse(Console.ReadLine());
                    corretora.AlterarPrecoDoImovel(enderecoAlterar, novoPreco);
                    break;

                case 3:
                    corretora.ListarImoveis();
                    break;

                case 4:
                    double valorMedio = corretora.CalcularValorMedio();
                    Console.WriteLine($"O valor médio dos imóveis é: R${valorMedio}");
                    break;

                case 5:
                    Console.WriteLine("Saindo do programa.");
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

        }
    }
}