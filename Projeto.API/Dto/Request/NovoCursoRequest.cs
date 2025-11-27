using Projeto.Domain.Entidades;

namespace Projeto.API.Dto.Request
{
    public class NovoCursoRequest
    {
        public string Nome { get; set; }

        public Curso ToEntity()
        {
            return new Curso
            {
                Nome = this.Nome
            };
        }
    }
}
