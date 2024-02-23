using ScreenSound_IntegrationAPI.Filters;
using ScreenSound_IntegrationAPI.Models;
using System.Text.Json;

var urlApi = "https://guilhermeonrails.github.io/api-csharp-songs/songs.json";

using (HttpClient client = new HttpClient())
{
    try
    {
        var resposta = await client.GetStringAsync(urlApi);
        Console.WriteLine(resposta);

        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        LinqFilterForOrder.ExibirArtistasOrdenados(musicas);

    }catch(Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
