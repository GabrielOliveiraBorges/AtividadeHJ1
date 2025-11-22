using Projeto.Domain.Entidades;

namespace Projeto.Domain.Interfaces
{
    public interface IMatriculaService
    {
        Matricula Criar(Matricula matricula);
        Matricula Atualizar(Matricula matricula);
        void Deletar(int id);
        Matricula BuscarPorId(int id);
        IEnumerable<Matricula> Listar();
    }
}
