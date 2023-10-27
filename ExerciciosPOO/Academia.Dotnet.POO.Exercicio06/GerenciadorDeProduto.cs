namespace Academia.Dotnet.POO.Exercicio06
{
    public class GerenciadorDeProduto
    {
        private List<Produto> listaDeProdutos = new List<Produto>();

        public GerenciadorDeProduto()
        {
            listaDeProdutos = new List<Produto>();
        }

        public void AdicionarProduto(int codigo, string nome, double preco, int quantidadeEmEstoque)
        {
            Produto novoProduto = new Produto(codigo, nome, preco, quantidadeEmEstoque);
            listaDeProdutos.Add(novoProduto);
        }

        public void RemoverProduto(int codigoInformado)
        {
            Produto produtoParaRemover = listaDeProdutos.Find(p => p.codigo == codigoInformado);

            if (produtoParaRemover != null)
            {
                listaDeProdutos.Remove(produtoParaRemover);
            }
        }

        public List<Produto> ListarProdutos()
        {
            return listaDeProdutos;
        }

        public Produto BuscarProdutoPorCodigo(int codigoInformado)
        {
            return listaDeProdutos.Find(p => p.codigo == codigoInformado);
        }
    }
}
