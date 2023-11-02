namespace Academia.Dotnet.POO.Exercicio09
{
    public class Livro
    {
        private string _titulo;
        private string _autor;

        public Livro(string titulo, string autor)
        {
            ValidarDados(titulo, autor);
            _titulo = titulo;
            _autor = autor;
        }

        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }

        public string Autor
        {
            get { return _autor; }
            set { _autor = value; }
        }

        private void ValidarDados(string titulo, string nome) 
        {
            if (string.IsNullOrWhiteSpace(titulo))
            {
                throw new ArgumentException("o título do livro não pode ser vazio ou nulo!");
            }
            else if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("o nome do autor não pode ser vazio ou nulo!");
            }
        }
    }
}
