namespace ScreenSoundV2.Classes
{
    public class Album
    {
        public string Nome { get; }

        public int DuracaoTotal => Musicas.Sum(m => m.Duracao);

        private List<Musica> Musicas = new List<Musica>();

        public Album(string nome)
        {
            Nome = nome;
        }

        public void AdicionaMusica(Musica musica)
        {
            Musicas.Add(musica);
        }

        public void ExibirMusicasDoAlbum()
        {
            Console.WriteLine($"Lista de músicas do album: {Nome}");
            foreach (var musica in Musicas)
            {Console.WriteLine($"Musica: {musica.Nome}");
                
            }

            Console.WriteLine($"Duração total do Album é: {DuracaoTotal / 60} minutos.");
        }
    }
}
