using ScreenSound_IntegrationAPI.Models;
using System.Net.NetworkInformation;

namespace ScreenSound_IntegrationAPI.Filters
{
    public class LinqFilter
    {
        public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
        {
            var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();

            foreach (var genero in todosOsGenerosMusicais)
            {
                Console.WriteLine($"-> {genero}");
            }
        }

        public static void ExibirArtistasOrdenados(List<Musica> musicas)
        {
            var artistarOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();

            foreach (var artista in artistarOrdenados)
            {
                Console.WriteLine($"-> {artista}");
            }
        }

        public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
        {
            var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero.Contains(genero)).Select(musica => musica.Artista).ToList().Distinct();

            foreach (var artista in artistasPorGeneroMusical)
            {
                Console.WriteLine($"Artista -> {artista}");
            }
        }

        public static void FiltrarMusicasPorArtista(List<Musica> musicas, string artista)
        {
            var musicasDoArtista = musicas.Where(musica => musica.Artista.Equals(artista)).Select(musica => musica.Nome).ToList().Distinct();

            Console.WriteLine($"Musicas do Artista: {artista}");
            Console.WriteLine($"=============================");
            foreach (var musica in musicasDoArtista)
            {
                Console.WriteLine($"-> {musica}");
            }
        }

        public static void FiltrarTodasAsMusicasPorTonalidade(List<Musica> musicas, string tonalidade)
        {
            var musicasPorTonalidade = musicas.Where(musica => musica.Tonalidade.Equals(tonalidade)).Select(musica => musica.Nome).ToList().Distinct();

            Console.WriteLine($"#Lista de todas as musicas da tonalidade: {tonalidade}");
            foreach (var musicaDaTonalidade in musicasPorTonalidade)
            {
                Console.WriteLine(musicaDaTonalidade);
            }
        }

    }
}
