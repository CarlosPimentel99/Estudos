using ScreenSound_IntegrationAPI.Models;

namespace ScreenSound_IntegrationAPI.Filters
{
    public class LinqFilter
    {
        public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
        {
            var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();

            foreach(var genero in todosOsGenerosMusicais)
            {
                Console.WriteLine($"-> {genero}");
            }
        }
    }
}
