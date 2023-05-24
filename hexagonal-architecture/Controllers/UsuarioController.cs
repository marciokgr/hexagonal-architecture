using System.Threading.Tasks;
using Domain.Adapters.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace hexagonal_architecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService) =>
            _usuarioService = usuarioService;

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var clubs = await _usuarioService.GetAll();
            return Ok(clubs);
        }

        [HttpPost]
        public async Task<IActionResult> Insert(Usuario usuarioService)
        {
            var id = await _usuarioService.Insert(usuarioService);

            return Ok(id);
        }
    }
}
