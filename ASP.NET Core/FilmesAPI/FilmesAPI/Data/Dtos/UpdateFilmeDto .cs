using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos
{
    public class UpdateFilmeDto
    {
        [Required(ErrorMessage = "Titulo do Filme é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Genero do Filme é obrigatório")]
        [StringLength(50, ErrorMessage = "O tamanho máximo do gênero não pode exceder 50 catacteres")]
        public string Genero { get; set; }
        [Required]
        [Range(70, 600, ErrorMessage = "A duração deve ser entre 70 à 600 minutos")]
        public int Duracao { get; set; }
    }
}
