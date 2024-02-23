using ScreenSound_IntegrationAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound_IntegrationAPI.Filters
{
    public class LinqFilterForOrder
    {
        public static void ExibirArtistasOrdenados(List<Musica> musicas)
        {
            var artistarOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();

            foreach(var artista  in artistarOrdenados)
            {
                Console.WriteLine($"-> {artista}");
            }
        }
    }
}
