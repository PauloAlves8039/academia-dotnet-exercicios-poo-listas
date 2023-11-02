using Academia.Dotnet.POO.Exercicio08;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Produtos e Fabricantes *****");

        Console.WriteLine("\nInforme os dados do Fabricante: ");

        Console.Write("Nome: ");
        string nomeDoFabricante = Console.ReadLine();

        Console.Write("Endereço: ");
        string endereco = Console.ReadLine();

        Console.Write("Cidade: ");
        string cidade = Console.ReadLine();

        Console.WriteLine("Informe os dados do Produto: ");

        Console.Write("Nome: ");
        string nomeDoProduto = Console.ReadLine();

        Console.Write("Preço: ");
        double preco = double.Parse(Console.ReadLine());

        Fabricante fabricante = new Fabricante(nomeDoFabricante, endereco, cidade);

        Produto produto = new Produto(nomeDoProduto, fabricante, preco);

        Console.WriteLine("\n----- Resultado -----");
        Console.WriteLine($"Produto: {produto.Nome}");
        Console.WriteLine($"Fabricante: {produto.Fabricante.Nome}");
        Console.WriteLine($"Preço: R${produto.Preco}");

        Console.ReadKey();

    }
}