using Academia.Dotnet.POO.Exercicio04;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Agenda Telefônica *****");

        AgendaTelefonica agenda = new AgendaTelefonica();

        while (true) 
        {
            Console.WriteLine("Opções:");
            Console.WriteLine("1. Adicionar contato");
            Console.WriteLine("2. Buscar contato");
            Console.WriteLine("3. Remover contato");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao) 
            {
                case 1:
                    Console.Write("Nome do contato: ");
                    string nome = Console.ReadLine();
                    Console.Write("Telefone do contato: ");
                    string telefone = Console.ReadLine();
                    Console.Write("Email do contato: ");
                    string email = Console.ReadLine();
                    Contato novoContato = new Contato(nome, telefone, email);
                    agenda.AdicionarContato(novoContato);
                    break;
                case 2:
                    Console.Write("Nome do contato a ser buscado: ");
                    string nomeBusca = Console.ReadLine();
                    Contato contatoEncontrado = agenda.BuscarContato(nomeBusca);
                    if (contatoEncontrado != null)
                    {
                        Console.WriteLine($"Contato encontrado: {contatoEncontrado.nome}, {contatoEncontrado.telefone}, {contatoEncontrado.email}");
                    }
                    else
                    {
                        Console.WriteLine("Contato não encontrado.");
                    }
                    break;
                case 3:
                    Console.Write("Nome do contato a ser removido: ");
                    string nomeRemocao = Console.ReadLine();
                    Contato contatoRemocao = agenda.BuscarContato(nomeRemocao);
                    if (contatoRemocao != null)
                    {
                        agenda.RemoverContato(contatoRemocao);
                        Console.WriteLine("Contato removido com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Contato não encontrado.");
                    }
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}