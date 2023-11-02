using Academia.Dotnet.POO.Exercicio11;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Meu Carro *****");


        Console.WriteLine("\nDigite as informações do seu carro:");
        Console.Write("Modelo: ");
        string modeloDoCarro = Console.ReadLine();
        Console.Write("Ano: ");
        int anoDeFabricacao = int.Parse(Console.ReadLine());

        Carro carro = new Carro(modeloDoCarro, anoDeFabricacao);

        Console.WriteLine("\n---------------- Resultado ----------------");
        Console.WriteLine($"Modelo: {carro.Modelo}, Ano: {carro.Ano}, Velocidade: {carro.Velocidade}");

        carro.Acelerar();
        Console.WriteLine($"Acelerando... Velocidade: {carro.Velocidade}");

        carro.Acelerar();
        Console.WriteLine($"Acelerando mais uma vez... Velocidade: {carro.Velocidade}");

        carro.Frear();
        Console.WriteLine($"Freando uma vez... Velocidade: {carro.Velocidade}");

        carro.Frear();
        Console.WriteLine($"Freando... Velocidade: {carro.Velocidade}");

        Console.ReadKey();
    }
}