using Microsoft.AspNetCore.Mvc;
using ProjetoPapaiNoel.Application.Services;
using ProjetoPapaiNoel.Domain.Entidades;
using System;

namespace ProjetoPapaiNoel.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartinhaController : ControllerBase
    {
        private readonly CartinhaService _service;

        public CartinhaController(CartinhaService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Cartinha cartinha)
        {
            try
            {
                _service.AdicionarCartinha(cartinha);
                return CreatedAtAction(nameof(Post), new { id = cartinha.Id }, cartinha);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            var lista = _service.ListarCartinhas();
            return Ok(lista);
        }
    }
}
