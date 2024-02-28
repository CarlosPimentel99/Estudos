using System.Text.Json;

namespace ScreenSound_IntegrationAPI.Models
{
    public class MusicasPreferidas
    {
        public string? Nome { get; set; }
        public List<Musica> ListaDeMusicas { get; set; }

        public MusicasPreferidas(string? nome)
        {
            Nome = nome;
            ListaDeMusicas = new List<Musica>();
        }

        public void AdicionarMusicasFavoritas(Musica musica)
        {
            ListaDeMusicas.Add(musica);
        }

        public void ExibirMusicasFavoritas()
        {
            Console.WriteLine($"Essas são as musicas favoritas: {Nome}");

            foreach (var musica in ListaDeMusicas) { Console.WriteLine($"-> {musica.Nome}"); }
        }

        public void GerarArquivoJson()
        {
            string json = JsonSerializer.Serialize(new
            {
                nome = Nome,
                musicas = ListaDeMusicas
            });

            var nomeArquivo = $"musicas-favoritas-{Nome}-Json";

            File.WriteAllText(nomeArquivo, json);
            Console.WriteLine($"Arquivo Json Criado com Sucerro no caminho: {Path.GetFullPath(nomeArquivo)}");
        }
    }
}
