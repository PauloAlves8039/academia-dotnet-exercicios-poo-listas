namespace Academia.Dotnet.POO.Exercicio01
{
    public class Produto
    {
        public string nome;
        public double preco;
        public int quantidadeEmEstoque;

        public Produto(string nome, double preco, int quantidadeEmEstoque)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidadeEmEstoque = quantidadeEmEstoque;
        }

        public void AdicionarItemNoEstoque(int quantidade) 
        {
            if (quantidade > 0)
            {
                quantidadeEmEstoque += quantidade;
                Console.WriteLine($"{quantidade} unidades de {nome} adicionadas no estoque. Novo estoque: {quantidadeEmEstoque} unidades.");
            }
            else 
            {
                Console.WriteLine("A quantidade adicionada deve ser maior que zero!");
            }
        }

        public void RemoverItemDoEstoque(int quantidade) 
        {
            if (quantidade > 0 && quantidade <= quantidadeEmEstoque)
            {
                quantidadeEmEstoque -= quantidade;
                Console.WriteLine($"{quantidade} unidades de {nome} removidas do estoque. Novo estoque: {quantidadeEmEstoque} unidades.");
            }
            else if (quantidade > quantidadeEmEstoque)
            {
                Console.WriteLine("A quantidade a ser removida é maior do que a quantidade em estoque.");
            }
            else 
            {
                Console.WriteLine("A quantidade adicionada deve ser maior que zero!");
            }
        }
    }
}
