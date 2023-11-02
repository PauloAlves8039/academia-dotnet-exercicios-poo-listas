namespace Academia.Dotnet.POO.Exercicio12
{
    public class Agenda
    {
        private List<Pessoa> _listaDePessoas;

        public Agenda()
        {
            _listaDePessoas = new List<Pessoa>();
        }

        public void ArmazenaPessoa(string nome, int idade, float altura)
        {
            Pessoa pessoa = new Pessoa(nome, idade, altura);
            _listaDePessoas.Add(pessoa);
        }

        public void RemovePessoa(string nome)
        {
            Pessoa pessoa = BuscaPessoa(nome);

            if (pessoa != null)
            {
                _listaDePessoas.Remove(pessoa);
            }
            else
            {
                Console.WriteLine("Pessoa não encontrada na agenda.");
            }
        }

        public Pessoa BuscaPessoa(string nome)
        {
            return _listaDePessoas.Find(p => p.Nome == nome);
        }

        public void ImprimeAgenda()
        {
            Console.WriteLine("Agenda:");

            foreach (var pessoa in _listaDePessoas)
            {
                Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}, Altura: {pessoa.Altura}");
            }
        }
    }
}
