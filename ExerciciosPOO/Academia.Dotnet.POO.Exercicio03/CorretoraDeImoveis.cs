using System.Globalization;

namespace Academia.Dotnet.POO.Exercicio03
{
    public class CorretoraDeImoveis
    {
        private List<Imovel> listaDeImoveis = new List<Imovel>();

        public void InserirImovel(string endereco, double preco, string tipo)
        {
            Imovel imovel = new Imovel(endereco, preco, tipo);
            listaDeImoveis.Add(imovel);
            Console.WriteLine("Imóvel inserido com sucesso!");
        }

        public void AlterarPrecoDoImovel(string enderecoInformado, double novoPreco)
        {
            Imovel imovel = listaDeImoveis.Find(i => i.endereco == enderecoInformado);

            if (imovel != null)
            {
                imovel.preco = novoPreco;
                Console.WriteLine("Preço do imóvel alterado com sucesso!");
            }
            else
            {
                Console.WriteLine("Imóvel não encontrado.");
            }
        }

        public void ListarImoveis()
        {
            Console.WriteLine("Imóveis disponíveis:");

            foreach (Imovel imovel in listaDeImoveis)
            {
                Console.WriteLine($"Endereço: {imovel.endereco}, Tipo: {imovel.tipo}, Preço: R${imovel.preco.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }

        public double CalcularValorMedio()
        {
            if (listaDeImoveis.Count == 0)
            {
                return 0;
            }

            double somaPrecos = listaDeImoveis.Sum(imovel => imovel.preco);
            somaPrecos.ToString("F2", CultureInfo.InvariantCulture);
            return somaPrecos / listaDeImoveis.Count;
        }
    }
}
