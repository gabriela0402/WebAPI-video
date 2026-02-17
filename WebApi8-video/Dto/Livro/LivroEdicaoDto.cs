using WebApi8_video.Dto.Livro.Vinculo;
using WebApi8_video.Models;

namespace WebApi8_video.Dto.Livro
{
    public class LivroEdicaoDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public AutorVinculoDto Autor { get; set; }
    }
}
