using Academia.Dotnet.POO.Exercicio06;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Gerenciador de Produtos *****");

        GerenciadorDeProduto gerenciador = new GerenciadorDeProduto();

        while (true) 
        {
            Console.WriteLine("\nOpções:");
            Console.WriteLine("1 - Adicionar Produto");
            Console.WriteLine("2 - Listar Produtos");
            Console.WriteLine("3 - Consultar Produto por Código");
            Console.WriteLine("4 - Sair");

            Console.Write("Escolha uma opção: ");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha) 
            {
                case 1:
                    Console.Write("Informe o código do produto: ");
                    int codigo = int.Parse(Console.ReadLine());

                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Preço: ");
                    double preco = double.Parse(Console.ReadLine());

                    Console.Write("Quantidade em Estoque: ");
                    int quantidadeEmEstoque = int.Parse(Console.ReadLine());

                    gerenciador.AdicionarProduto(codigo, nome, preco, quantidadeEmEstoque);
                    Console.WriteLine("Produto adicionado com sucesso.");
                    break;

                case 2:
                    Console.WriteLine("----- Lista de Produtos -----");
                    var listaDeProdutos = gerenciador.ListarProdutos();
                    foreach (var produto in listaDeProdutos)
                    {
                        Console.WriteLine($"Código: {produto.codigo}, Nome: {produto.nome}, Preço: {produto.preco:C}, Quantidade em Estoque: {produto.quantidadeEmEstoque}");
                    }
                    break;

                case 3:
                    Console.Write("Informe o código do produto a ser consultado: ");
                    int codigoConsulta = int.Parse(Console.ReadLine());

                    Produto produtoConsultado = gerenciador.BuscarProdutoPorCodigo(codigoConsulta);

                    if (produtoConsultado != null)
                    {
                        Console.WriteLine($"Produto encontrado: Código: {produtoConsultado.codigo}, Nome: {produtoConsultado.nome}, Preço: {produtoConsultado.preco:C}, Quantidade em Estoque: {produtoConsultado.quantidadeEmEstoque}");
                    }
                    else
                    {
                        Console.WriteLine("Produto não encontrado.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Encerrando o programa.");
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}