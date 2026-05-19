using back_end.Data;
using back_end.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace back_end.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public AuthController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        // POST api/auth/login
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var usuario = await _appDbContext.Usuarios
                .FirstOrDefaultAsync(u => u.email == request.email && u.password == request.password);

            if (usuario == null)
                return Unauthorized(new { message = "E-mail ou senha incorretos." });

            return Ok(new
            {
                message = "Login realizado com sucesso.",
                id = usuario.id,
                nickname = usuario.nickname,
                nome = usuario.nome,
                email = usuario.email
            });
        }
    }
}
