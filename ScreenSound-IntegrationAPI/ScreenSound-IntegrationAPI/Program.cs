using ScreenSound_IntegrationAPI.Filters;
using ScreenSound_IntegrationAPI.Models;
using System.Text.Json;

var urlApi = "https://guilhermeonrails.github.io/api-csharp-songs/songs.json";

using (HttpClient client = new HttpClient())
{
    try
    {
        var resposta = await client.GetStringAsync(urlApi);
        //Console.WriteLine(resposta);

        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        //musicas[1].ExibirDetalhesMusica();

        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqFilter.ExibirArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        //LinqFilter.FiltrarMusicasPorArtista(musicas, "50 Cent");

        //var musicasPreferidas = new MusicasPreferidas("Teste");

        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[2]);
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[3]);
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[4]);
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[5]);

        ////musicasPreferidas.ExibirMusicasFavoritas();

        //musicasPreferidas.GerarArquivoJson();

        LinqFilter.FiltrarTodasAsMusicasPorTonalidade(musicas, "F#");

    }catch(Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
