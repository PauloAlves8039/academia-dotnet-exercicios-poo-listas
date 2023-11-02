namespace Academia.Dotnet.POO.Exercicio08
{
    public class Fabricante
    {
        private string _nome;
        private string _endereco;
        private string _cidade;

        public Fabricante(string nome, string endereco, string cidade)
        {
            _nome = nome;
            _endereco = endereco;
            _cidade = cidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value == null || value.Length == 0)
                {
                    Console.WriteLine("Erro: o nome do Fabricante não pode ser vazio ou nulo.");
                }

                _nome = value;
            }
        }

        public string Endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }

        public string Cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }
    }
}
