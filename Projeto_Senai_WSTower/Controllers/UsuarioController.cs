using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_Senai_WSTower.Domains;
using Projeto_Senai_WSTower.Repositories;

namespace Projeto_Senai_WSTower.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
  
    public class UsuarioController : ControllerBase
    {
        UsuarioRepository usuarioRepository = new UsuarioRepository();
        
        [HttpGet]
        public IActionResult ListarTodos()
        {
            return Ok(usuarioRepository.Listar());
        }

        [HttpPost]
        public IActionResult Post(Usuario novoUsuario)
        {
            try
            {
                usuarioRepository.Cadastrar(novoUsuario);
                return StatusCode(201);
            }
            catch (Exception error)
            {
                return BadRequest(error);
            }
        }
    }
}
