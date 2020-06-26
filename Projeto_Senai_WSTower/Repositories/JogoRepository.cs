using Projeto_Senai_WSTower.contexts;
using Projeto_Senai_WSTower.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;

namespace Projeto_Senai_WSTower.Repositories
{
    public class JogoRepository
    {
        CampeonatoContext ctx = new CampeonatoContext();
        public Jogo BuscarPorId(int id)
        {
            Jogo jogoBuscado = ctx.Jogo
                .Select(j => new Jogo()
                {
                    Id = j.Id,
                    SelecaoCasa = j.SelecaoCasa,
                    SelecaoVisitante = j.SelecaoVisitante,
                    PlacarCasa = j.PlacarCasa,
                    PlacarVisitante = j.PlacarVisitante,
                    PenaltisCasa = j.PenaltisCasa,
                    PenaltisVisitante = j.PenaltisVisitante,
                    Data = j.Data,
                    Estadio = j.Estadio
                })
                .FirstOrDefault(j => j.Id == id);
            if (jogoBuscado != null)
            {
                return jogoBuscado;
            }
            return null;
        }
    }
}
