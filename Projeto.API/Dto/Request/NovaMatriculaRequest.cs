using Projeto.Domain.Entidades;

namespace Projeto.API.Dto.Request
{
    public class NovaMatriculaRequest
    {
        public int AlunoId { get; set; }
        public int CursoId { get; set; }

        public Matricula ToEntity()
        {
            return new Matricula
            {
                AlunoId = this.AlunoId,
                CursoId = this.CursoId
            };
        }
    }
}
