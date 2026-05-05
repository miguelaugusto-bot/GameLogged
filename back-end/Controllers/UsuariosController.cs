using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back_end.Data;
using back_end.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace back_end.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        //constructor para injetar o AppDbContext
        public UsuariosController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        //efetuar a consulta para verificar se o usuário existe, se não existir, criar um novo usuário
        [HttpPost]
        public async Task<IActionResult> CriarUsuario(Usuario usuario)
        {
            _appDbContext.Usuarios.Add(usuario);

            await _appDbContext.SaveChangesAsync();
            return Ok(usuario);

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuarios()
        {
            var usuarios = await _appDbContext.Usuarios.ToListAsync();
            return Ok(usuarios);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> GetUsuario(int id)
        {
            var usuario = await _appDbContext.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound("Não foi localizado");
            }
            return Ok(usuario);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUsuario(int id, [FromBody] Usuario usuarioUpdate)
        {
            if (id != usuarioUpdate.idusers)
            {
                return BadRequest("ID do usuário não corresponde ao ID fornecido.");
            }

            var usuarioExistente = await _appDbContext.Usuarios.FindAsync(id);
            if (usuarioExistente == null)
            {
                return NotFound("Usuário não encontrado.");
            }

            _appDbContext.Entry(usuarioExistente).CurrentValues.SetValues(usuarioUpdate);

            await _appDbContext.SaveChangesAsync();
            return StatusCode(201, usuarioExistente);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuario(int id)
        {
            var usuarioExistente = await _appDbContext.Usuarios.FindAsync(id);
            if (usuarioExistente == null)
            {
                return NotFound("Usuário não encontrado.");
            }

            _appDbContext.Usuarios.Remove(usuarioExistente);
            await _appDbContext.SaveChangesAsync();

            return Ok();
        }
    }
}