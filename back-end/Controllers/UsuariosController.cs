using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back_end.Data;
using back_end.Models;
using Microsoft.AspNetCore.Mvc;

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
    }
}