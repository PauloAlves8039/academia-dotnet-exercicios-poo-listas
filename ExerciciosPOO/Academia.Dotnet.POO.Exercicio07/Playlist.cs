namespace Academia.Dotnet.POO.Exercicio07
{
    public class Playlist
    {
        private List<Musica> listaDeMusicas = new List<Musica>();
        public string dono;

        public Playlist(string dono)
        {
            this.dono = dono;
        }

        public void AdicionarMúsica(Musica música)
        {
            listaDeMusicas.Add(música);
        }

        public void TocarMúsicaAleatória()
        {
            if (listaDeMusicas.Count > 0)
            {
                Random random = new Random();
                int índiceAleatório = random.Next(listaDeMusicas.Count);
                Musica músicaTocada = listaDeMusicas[índiceAleatório];
                Console.WriteLine($"Tocando a música: {músicaTocada.nome} - {músicaTocada.autor}");
            }
            else
            {
                Console.WriteLine("A playlist está vazia. Adicione músicas antes de tocar.");
            }
        }
    }
}
