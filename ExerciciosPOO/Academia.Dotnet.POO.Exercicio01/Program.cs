using Academia.Dotnet.POO.Exercicio01;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Adicionar e Remover Produtos *****");

        Console.WriteLine("Informe os dados do produto: ");

        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Preço: ");
        double preco = double.Parse(Console.ReadLine());

        Console.Write("Quantidade em Estoque: ");
        int quantidadeEmEstoque = int.Parse(Console.ReadLine());

        Produto produto = new Produto(nome, preco, quantidadeEmEstoque);

        Console.WriteLine("----- Estoque -----");

        Console.WriteLine();

        Console.WriteLine("Adicione itens ao estoque: ");
        int adicionarItem = int.Parse(Console.ReadLine());

        produto.AdicionarItemNoEstoque(adicionarItem);

        Console.WriteLine();

        Console.WriteLine("Remova itens do estoque: ");
        int removerItem = int.Parse(Console.ReadLine());

        produto.RemoverItemDoEstoque(removerItem);

        Console.ReadKey();
    }
}