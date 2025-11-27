using Microsoft.AspNetCore.Mvc;
using Projeto.API.Dto.Request;
using Projeto.Application.Services;
using Projeto.Domain.Interfaces;

namespace Projeto.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MatriculaController : ControllerBase
    {
        private readonly IMatriculaService _matriculaService;

        public MatriculaController(IMatriculaService matriculaService)
        {
            _matriculaService = matriculaService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var matriculas = _matriculaService.BuscarTodos();
            return Ok(matriculas);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var matricula = _matriculaService.BuscarPorId(id);
            return Ok(matricula);
        }

        [HttpPost]
        public IActionResult Create(NovaMatriculaRequest request)
        {
            var matricula = _matriculaService.Adicionar(request.ToEntity());
            return Created("", matricula);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _matriculaService.Remover(id);
            return NoContent();
        }
    }
}
