namespace ScreenSoundV2.Classes
{
    public class Banda
    {
        private List<Album> Albums = new List<Album>();

        public Banda(string nome)
        {
            this.Nome = nome;
        }

        public string Nome { get;}

        public void AdicionarAlbum(Album album)
        {
            Albums.Add(album);
        }

        public void ExibirDiscografia()
        {
            Console.WriteLine($"Discografia da banda: {Nome}");
            foreach(Album album in Albums)
            {
                Console.WriteLine($"Album: {album.Nome} e tem duração total de: {album.DuracaoTotal / 60} minutos.");
            }
        }


    }
}
