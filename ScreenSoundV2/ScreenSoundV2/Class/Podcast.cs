namespace ScreenSoundV2.Classes
{
    public class Podcast
    {
        public string Host { get; }

        public string Nome { get; }

        public int TotalEpisodio
        {
            get
            {
                return EpisodiosPodCast.Count();
            }
        }

        public List<Episodio> EpisodiosPodCast { get; set; } = new List<Episodio>();

        public Podcast(string host, string nome)
        {
            Host = host;
            Nome = nome;
        }

        public void AdicionarEpisodio(Episodio episodio)
        {
            EpisodiosPodCast.Add(episodio);
        }

        public void ExibirDetalhes()
        {
            // Nome podcast e seu Host na primeira Linha
            Console.WriteLine($"Podcast: {Nome} com seguinte Host: {Host}");

            Console.WriteLine("Segue Lista de Espisódios:");

            foreach (var episodio in EpisodiosPodCast.OrderBy(e => e.Ordem))
            {
                Console.WriteLine(episodio.Titulo);
                Console.WriteLine(episodio.Resumo);
            }

            Console.WriteLine($"Total de Episódios: {TotalEpisodio}");
        }
    }
}
