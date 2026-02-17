using System.Text.Json.Serialization;
using WebApi8_video.Models;

namespace WebApi8_video.Dto.Livro.Vinculo
{
    public class AutorVinculoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
    }
}
