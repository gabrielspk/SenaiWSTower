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
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class JogoController : ControllerBase
    {
        JogoRepository jogoRepository = new JogoRepository();
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                Jogo jogoBuscado = jogoRepository.BuscarPorId(id);
                if (jogoBuscado != null)
                {
                    return Ok(jogoBuscado);
                }
                return NotFound("Nenhum jogo encontrado para o id informado");
            }
            catch (Exception error)
            {
                return BadRequest(error);
            }
        }
    }
}
