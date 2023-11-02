using Academia.Dotnet.POO.Exercicio09;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("******** Livro ********");

        Console.WriteLine("Digite os dados do Livro: ");
        Console.Write("Título: ");
        string tituloDoLivro = Console.ReadLine();
        Console.Write("Autor: ");
        string nomeDoAutor = Console.ReadLine();

        Console.WriteLine("\n-------- Resultado --------");

        try 
        {
            Livro livro = new Livro(tituloDoLivro, nomeDoAutor);
            Console.WriteLine($"Título: {livro.Titulo}");
            Console.WriteLine($"Autor: {livro.Autor}");
        }
        catch (ArgumentException exception) 
        {
            Console.WriteLine($"Erro: {exception.Message}");
        }

        Console.ReadKey();
    }
}