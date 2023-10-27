namespace Academia.Dotnet.POO.Exercicio02
{
    public class Compra
    {
        public DateTime data;
        public string produto;
        public double valor;

        public Compra(DateTime data, string produto, double valor)
        {
            this.data = data;
            this.produto = produto;
            this.valor = valor;
        }
    }
}
