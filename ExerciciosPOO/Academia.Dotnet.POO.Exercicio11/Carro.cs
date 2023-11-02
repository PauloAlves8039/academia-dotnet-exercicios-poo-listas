namespace Academia.Dotnet.POO.Exercicio11
{
    public class Carro
    {
        private string _modelo;
        private int _ano;
        private int _velocidade;

        public Carro(string modelo, int ano)
        {
            _modelo = modelo;
            _ano = ano;
            _velocidade = 0;
        }

        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }

        public int Ano
        {
            get { return _ano; }
            set { _ano = value; }
        }

        public int Velocidade
        {
            get { return _velocidade; }
        }

        public void Acelerar()
        {
            _velocidade += 10;
        }

        public void Frear()
        {
            if (_velocidade >= 10)
            {
                _velocidade -= 10;
            }
            else
            {
                _velocidade = 0;
            }
        }
    }
}
