namespace Academia.Dotnet.POO.Exercicio05
{
    public class Tarefa
    {
        public string descricao;
        public DateTime dataVencimento;

        public Tarefa(string descricao, DateTime dataVencimento)
        {
            this.descricao = descricao;
            this.dataVencimento = dataVencimento;
        }

        public bool DeveSerExecutadaHoje()
        {
            return dataVencimento.Date == DateTime.Today;
        }

    }
}
