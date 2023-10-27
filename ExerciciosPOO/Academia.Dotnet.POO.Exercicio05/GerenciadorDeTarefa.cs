namespace Academia.Dotnet.POO.Exercicio05
{
    public class GerenciadorDeTarefa
    {
        private List<Tarefa> ListaDeTarefas;

        public GerenciadorDeTarefa()
        {
            ListaDeTarefas = new List<Tarefa>();
        }

        public void AdicionarTarefa(string descricao, DateTime dataVencimento)
        {
            Tarefa novaTarefa = new Tarefa(descricao, dataVencimento);
            ListaDeTarefas.Add(novaTarefa);
        }

        public void RemoverTarefa(string descricaoInformada)
        {
            Tarefa tarefaParaRemover = ListaDeTarefas.Find(t => t.descricao == descricaoInformada);
            if (tarefaParaRemover != null)
            {
                ListaDeTarefas.Remove(tarefaParaRemover);
            }
        }

        public List<Tarefa> ListarTarefas()
        {
            return ListaDeTarefas;
        }

        public List<Tarefa> TarefasParaExecutarHoje()
        {
            return ListaDeTarefas.FindAll(tarefas => tarefas.DeveSerExecutadaHoje());
        }
    }
}
