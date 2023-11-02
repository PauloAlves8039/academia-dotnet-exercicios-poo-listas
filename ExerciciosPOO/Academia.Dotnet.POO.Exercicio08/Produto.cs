namespace Academia.Dotnet.POO.Exercicio08
{
    public class Produto
    {
        private string _nome;
        private Fabricante _fabricante;
        private double _preco;

        public Produto(string nome, Fabricante fabricante, double preco)
        {
            _nome = nome;
            _fabricante = fabricante;
            _preco = preco;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value == null || value.Length == 0)
                {
                    Console.WriteLine("Erro: o nome do Produto não pode ser vazio ou nulo.");
                }

                _nome = value;
            }
        }

        public Fabricante Fabricante
        {
            get { return _fabricante; }
            set { _fabricante = value; }
        }

        public double Preco
        {
            get { return _preco; }
            set
            {
                if (_preco < 0)
                {
                    Console.WriteLine("Erro: o preço deve ser positivo.");
                }

                _preco = value;
            }
        }
    }
}
