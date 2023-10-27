using Academia.Dotnet.POO.Exercicio07;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Bem-vindo(a) à sua playlist! *****");

        Console.Write("Informe o nome do dono da playlist: ");
        string donoDaPlaylist = Console.ReadLine();

        Playlist minhaPlaylist = new Playlist(donoDaPlaylist);

        while (true) 
        {
            Console.WriteLine("\nOpções:");
            Console.WriteLine("1 - Adicionar música");
            Console.WriteLine("2 - Tocar música aleatória");
            Console.WriteLine("3 - Sair");

            Console.Write("Escolha uma opção: ");
            string escolha = Console.ReadLine();

            if (escolha == "1")
            {
                Console.Write("Informe o nome da música: ");
                string nome = Console.ReadLine();

                Console.Write("Informe o nome do autor: ");
                string autor = Console.ReadLine();

                Console.Write("Informe o nome da gravadora: ");
                string gravadora = Console.ReadLine();

                Musica novaMusica = new Musica(nome, autor, gravadora);
                minhaPlaylist.AdicionarMúsica(novaMusica);
            }
            else if (escolha == "2")
            {
                minhaPlaylist.TocarMúsicaAleatória();
            }
            else if (escolha == "3")
            {
                break;
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }
        }

    }
}