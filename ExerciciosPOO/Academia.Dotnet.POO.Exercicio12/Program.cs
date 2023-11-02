using Academia.Dotnet.POO.Exercicio12;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Agenda de Contatos *****");

        Agenda agenda = new Agenda();

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Adicionar Pessoa");
            Console.WriteLine("2. Remover Pessoa");
            Console.WriteLine("3. Buscar Pessoa");
            Console.WriteLine("4. Imprimir Agenda");
            Console.WriteLine("5. Sair");

            Console.Write("\nOpção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("\nDigite os dados da pessoa: ");
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Idade: ");
                    int idade = int.Parse(Console.ReadLine());
                    Console.Write("Altura: ");
                    float altura = float.Parse(Console.ReadLine());
                    agenda.ArmazenaPessoa(nome, idade, altura);
                    break;

                case 2:
                    Console.Write("Nome da pessoa a ser removida: ");
                    string nomeParaRemocao = Console.ReadLine();
                    agenda.RemovePessoa(nomeParaRemocao);
                    break;

                case 3:
                    Console.Write("Nome da pessoa que deseja buscar: ");
                    string nomeParaBusca = Console.ReadLine();
                    Pessoa pessoa = agenda.BuscaPessoa(nomeParaBusca);

                    if (pessoa != null)
                    {
                        Console.WriteLine($"Pessoa encontrada - Nome: {pessoa.Nome}, Idade: {pessoa.Idade}, Altura: {pessoa.Altura}");
                    }
                    else
                    {
                        Console.WriteLine("Pessoa não encontrada na agenda!");
                    }
                    break;

                case 4:
                    agenda.ImprimeAgenda();
                    break;

                case 5:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Opção inválida, tente novamente!");
                    break;
            }
        }
    }
}