using Projeto.Domain.Entidades;
using System.Collections.Generic;

namespace Projeto.Domain.Interfaces
{
    public interface ICursoRepository
    {
        Curso Adicionar(Curso curso);
        Curso Atualizar(Curso curso);
        void Remover(int idCurso);
        Curso BuscarPorId(int idCurso);
        List<Curso> BuscarTodos();
    }
}
