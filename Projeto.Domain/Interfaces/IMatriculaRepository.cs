using Projeto.Domain.Entidades;

namespace Projeto.Domain.Interfaces
{
    public interface IMatriculaRepository
    {
        Matricula Criar(Matricula matricula);
        Matricula Atualizar(Matricula matricula);
        void Deletar(int id);
        Matricula BuscarPorId(int id);
        IEnumerable<Matricula> Listar();
        Matricula BuscarPorAlunoECurso(int idAluno, int idCurso);
    }
}
