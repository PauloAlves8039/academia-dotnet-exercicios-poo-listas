namespace Academia.Dotnet.POO.Exercicio10
{
    public class Animal
    {
        private string _nome;
        private string _especie;
        private int _idade;

        public Animal(string nome, string especie, int idade)
        {
            _nome = nome;
            _especie = especie;
            _idade = idade;
        }

        public string Nome 
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Especie
        {
            get { return _especie; }
            set { _especie = value; }
        }

        public int Idade
        {
            get { return _idade; }
            set { _idade = value; }
        }

        public void EmitirSom(string somDoAnimal)
        {
            Console.WriteLine(somDoAnimal);
        }
    }
}
