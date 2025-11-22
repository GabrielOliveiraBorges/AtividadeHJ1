using Projeto.Domain.Entidades;
using Projeto.Domain.Interfaces;

namespace Projeto.Data.Repositories
{
    public class CursoRepository : ICursoRepository
    {
        public Curso Criar(Curso curso) => curso;
        public Curso Atualizar(Curso curso) => curso;
        public void Deletar(int idCurso) { }
        public Curso BuscarPorId(int idCurso) => null;
        public IEnumerable<Curso> Listar() => new List<Curso>();
    }
}
