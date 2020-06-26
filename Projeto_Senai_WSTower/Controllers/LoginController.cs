using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_Senai_WSTower.Domains;
using Projeto_Senai_WSTower.Repositories;
using Projeto_Senai_WSTower.ViewModels;

namespace Projeto_Senai_WSTower.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        UsuarioRepository usuarioRepository = new UsuarioRepository();
        
        [HttpPost]
        public IActionResult Post(LoginViewModel login)
        {
            
            try
            {
                Usuario usuarioBuscado = usuarioRepository.Login(login.Email, login.Senha);

                if (usuarioBuscado == null)
                {
                    return NotFound("Email ou senha inválidos!");
                }
                return Ok("Usuario logado");
            }
            catch (Exception error)
            {
                return BadRequest(new
                {
                    mensagem = "Algo deu errado",
                    error
                });
            }
        }
    }
}
