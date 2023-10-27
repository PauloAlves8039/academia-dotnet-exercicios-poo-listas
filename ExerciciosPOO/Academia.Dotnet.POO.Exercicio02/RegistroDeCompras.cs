using System.Globalization;

namespace Academia.Dotnet.POO.Exercicio02
{
    public class RegistroDeCompras
    {
        private List<Compra> compras;

        public RegistroDeCompras()
        {
            compras = new List<Compra>();
        }

        public void AdicionarCompra(DateTime data, string produto, double valor)
        {
            Compra novaCompra = new Compra(data, produto, valor);
            compras.Add(novaCompra);
        }

        public void ListarCompras()
        {
            Console.WriteLine("Lista de Compras: ");

            foreach (Compra compra in compras)
            {
                Console.WriteLine($"Data: {compra.data}, Produto: {compra.produto}, Valor: {compra.valor.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
