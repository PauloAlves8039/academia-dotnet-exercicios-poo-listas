using Academia.Dotnet.POO.Exercicio02;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Registro De Compras *****");

        RegistroDeCompras registro = new RegistroDeCompras();

        Console.WriteLine("Informe os dados das compras: ");

        while (true)
        {
            Console.Write("Data da compra (AAAA-MM-DD): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime data))
            {
                Console.Write("Nome do produto: ");
                string produto = Console.ReadLine();

                Console.Write("Valor da compra: ");
                if (double.TryParse(Console.ReadLine(), out double valor))
                {
                    registro.AdicionarCompra(data, produto, valor);
                }
                else
                {
                    Console.WriteLine("Valor inválido. Certifique-se de digitar um número válido.");
                }
            }
            else
            {
                Console.WriteLine("Data inválida. Certifique-se de digitar uma data no formato AAAA-MM-DD.");
            }

            Console.Write("Deseja adicionar outra compra? (S/N): ");
            string resposta = Console.ReadLine();
            if (resposta.Equals("N", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }
        }

        registro.ListarCompras();

        Console.ReadKey();
    }
}