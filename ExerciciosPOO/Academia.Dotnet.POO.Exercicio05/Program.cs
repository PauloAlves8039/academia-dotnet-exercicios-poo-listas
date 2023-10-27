using Academia.Dotnet.POO.Exercicio05;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Gerenciador De Tarefa *****");

        GerenciadorDeTarefa gerenciador = new GerenciadorDeTarefa();

        while (true) 
        {
            Console.WriteLine("\nOpções:");
            Console.WriteLine("1 - Adicionar Tarefa");
            Console.WriteLine("2 - Listar Tarefas para Hoje");
            Console.WriteLine("3 - Listar Todas as Tarefas");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            Console.WriteLine();

            switch (opcao) 
            {
                case "1":
                    Console.Write("Informe a descrição da tarefa: ");
                    string descricao = Console.ReadLine();
                    Console.Write("Informe a data de vencimento (exemplo: 2023-10-26): ");
                    if (DateTime.TryParse(Console.ReadLine(), out DateTime dataVencimento))
                    {
                        gerenciador.AdicionarTarefa(descricao, dataVencimento);
                        Console.WriteLine("Tarefa adicionada com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Data inválida. A tarefa não foi adicionada.");
                    }
                    break;
                case "2":
                    List<Tarefa> tarefasHoje = gerenciador.TarefasParaExecutarHoje();
                    Console.WriteLine("Tarefas para hoje:");
                    foreach (Tarefa tarefa in tarefasHoje)
                    {
                        Console.WriteLine($"{tarefa.descricao} - {tarefa.dataVencimento}");
                    }
                    break;
                case "3":
                    List<Tarefa> todasAsTarefas = gerenciador.ListarTarefas();
                    Console.WriteLine("Todas as tarefas:");
                    foreach (Tarefa tarefa in todasAsTarefas)
                    {
                        Console.WriteLine($"{tarefa.descricao} - {tarefa.dataVencimento}");
                    }
                    break;
                case "4":
                    Console.WriteLine("Saindo do programa.");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}