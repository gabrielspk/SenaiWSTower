using Projeto_Senai_WSTower.contexts;
using Projeto_Senai_WSTower.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Senai_WSTower.Repositories
{
    public class SelecaoRepository
    {
        CampeonatoContext ctx = new CampeonatoContext();
        public List<Selecao> Listar()
        { 
            {
            return ctx.Selecao.ToList();
            }
        }
    }
}
