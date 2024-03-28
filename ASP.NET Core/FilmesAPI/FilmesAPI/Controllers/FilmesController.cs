using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class FilmesController : ControllerBase
    {

        private static List<Filme> filmes = new List<Filme>();
        private static int id = 0;


        [HttpPost]
        public void AdicionaFilme([FromBody] Filme filme)
        {
            filme.Id = id++;
            filmes.Add(filme);
            Console.WriteLine(filme.Duracao);
            Console.WriteLine(filme.Titulo);
        }

        [HttpGet]
        public List<Filme> RecuperaFilmes()
        {
            return filmes;
        }

        [HttpGet("{id}")]
        public Filme? RecuparFilmePorId(int id)
        {
            return filmes.FirstOrDefault(filme => filme.Id == id);
        }
    }
}
