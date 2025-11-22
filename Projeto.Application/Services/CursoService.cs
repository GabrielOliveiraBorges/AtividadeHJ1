using Projeto.Domain.Entidades;
using Projeto.Domain.Interfaces;

namespace Projeto.Application.Services
{
    public class CursoService : ICursoService
    {
        private readonly ICursoRepository _repository;

        public CursoService(ICursoRepository repository)
        {
            _repository = repository;
        }

        public Curso Criar(Curso curso) => _repository.Criar(curso);
        public Curso Atualizar(Curso curso) => _repository.Atualizar(curso);
        public void Deletar(int idCurso) => _repository.Deletar(idCurso);
        public Curso BuscarPorId(int idCurso) => _repository.BuscarPorId(idCurso);
        public IEnumerable<Curso> Listar() => _repository.Listar();
    }
}
