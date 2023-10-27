namespace Academia.Dotnet.POO.Exercicio06
{
    public class Produto
    {
        public int codigo;
        public string nome;
        public double preco;
        public int quantidadeEmEstoque;

        public Produto(int codigo, string nome, double preco, int quantidadeEmEstoque)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.preco = preco;
            this.quantidadeEmEstoque = quantidadeEmEstoque;
        }
    }
}
