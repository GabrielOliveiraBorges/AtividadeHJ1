using Projeto.Domain.Entidades;
using Projeto.Domain.Interfaces;

namespace Projeto.Data.Repositories
{
    public class MatriculaRepository : IMatriculaRepository
    {
        public Matricula Criar(Matricula matricula) => matricula;
        public Matricula Atualizar(Matricula matricula) => matricula;
        public void Deletar(int id) { }
        public Matricula BuscarPorId(int id) => null;
        public IEnumerable<Matricula> Listar() => new List<Matricula>();
        public Matricula BuscarPorAlunoECurso(int idAluno, int idCurso) => null;
    }
}
