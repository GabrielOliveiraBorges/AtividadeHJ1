using Projeto.Domain.Entidades;

namespace Projeto.Domain.Interfaces
{
    public interface ICursoRepository
    {
        Curso Criar(Curso curso);
        Curso Atualizar(Curso curso);
        void Deletar(int idCurso);
        Curso BuscarPorId(int idCurso);
        IEnumerable<Curso> Listar();
    }
}
