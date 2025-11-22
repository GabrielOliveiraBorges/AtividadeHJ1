using Projeto.Domain.Entidades;
using Projeto.Domain.Interfaces;

namespace Projeto.Application.Services
{
    public class MatriculaService : IMatriculaService
    {
        private readonly IMatriculaRepository _matriculaRepository;
        private readonly ICursoRepository _cursoRepository;

        public MatriculaService(
            IMatriculaRepository matriculaRepository,
            ICursoRepository cursoRepository)
        {
            _matriculaRepository = matriculaRepository;
            _cursoRepository = cursoRepository;
        }

        public Matricula Criar(Matricula matricula)
        {
            return _matriculaRepository.Criar(matricula);
        }

        public Matricula Atualizar(Matricula matricula) =>
            _matriculaRepository.Atualizar(matricula);

        public void Deletar(int id) =>
            _matriculaRepository.Deletar(id);

        public Matricula BuscarPorId(int id) =>
            _matriculaRepository.BuscarPorId(id);

        public IEnumerable<Matricula> Listar() =>
            _matriculaRepository.Listar();
    }
}
