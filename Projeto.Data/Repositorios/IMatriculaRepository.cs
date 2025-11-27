using Projeto.Domain.Entidades;
using System.Collections.Generic;

namespace Projeto.Domain.Interfaces
{
    public interface IMatriculaRepository
    {
        Matricula Adicionar(Matricula matricula);
        void Remover(int id);
        Matricula BuscarPorId(int id);
        List<Matricula> BuscarTodos();
    }
}
