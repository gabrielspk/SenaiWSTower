using Microsoft.EntityFrameworkCore;
using Projeto_Senai_WSTower.contexts;
using Projeto_Senai_WSTower.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Senai_WSTower.Repositories
{
    public class UsuarioRepository
    {
        CampeonatoContext ctx = new CampeonatoContext();

       public List<Usuario> Listar()
        {
            return ctx.Usuario.ToList();
        }
        public Usuario Login(string email, string senha)
        {
            Usuario usuarioBuscado = ctx.Usuario
            .FirstOrDefault(u => u.Email == email && u.Senha == senha);

            if (usuarioBuscado != null)
            {
                return usuarioBuscado;
            }
            return null;
        }
        public void Cadastrar(Usuario novoUsuario)
        {
            ctx.Usuario.Add(novoUsuario);
            ctx.SaveChanges();
        }
    }
}
