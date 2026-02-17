using WebApi8_video.Dto.Livro.Vinculo;
using WebApi8_video.Models;

namespace WebApi8_video.Dto.Livro
{
    public class LivroCriacaoDto
    {
        public string Titulo { get; set; }
        public AutorVinculoDto Autor { get; set; }
    }
}
