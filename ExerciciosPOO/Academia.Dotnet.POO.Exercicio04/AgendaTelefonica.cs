namespace Academia.Dotnet.POO.Exercicio04
{
    public class AgendaTelefonica
    {
        private List<Contato> listaDeContatos;

        public AgendaTelefonica()
        {
            listaDeContatos = new List<Contato>();
        }

        public void AdicionarContato(Contato contatoInformado)
        {
            listaDeContatos.Add(contatoInformado);
        }

        public void RemoverContato(Contato contatoInformado)
        {
            listaDeContatos.Remove(contatoInformado);
        }

        public Contato BuscarContato(string nomeInformado)
        {
            return listaDeContatos.Find(c => c.nome == nomeInformado);
        }
    }
}
