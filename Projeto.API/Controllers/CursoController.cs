using Microsoft.AspNetCore.Mvc;
using Projeto.API.Dto.Request;
using Projeto.API.Dto.Response;
using Projeto.Application.Services;
using Projeto.Domain.Interfaces;

namespace Projeto.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CursoController : ControllerBase
    {
        private readonly ICursoService _cursoService;

        public CursoController(ICursoService cursoService)
        {
            _cursoService = cursoService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var cursos = _cursoService.BuscarTodos();
            return Ok(cursos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var curso = _cursoService.BuscarPorId(id);
            return Ok(curso);
        }

        [HttpPost]
        public IActionResult Create(NovoCursoRequest request)
        {
            var curso = _cursoService.Adicionar(request.ToEntity());
            return Created("", curso);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, AtualizarCursoRequest request)
        {
            var curso = _cursoService.Atualizar(id, request.ToEntity());
            return Ok(curso);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _cursoService.Remover(id);
            return NoContent();
        }
    }
}
