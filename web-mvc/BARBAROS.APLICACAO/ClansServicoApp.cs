using BARBAROS.REPOSITORIO_EXTERNO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BARBAROS.APLICACAO
{
    public class ClansServicoApp : IClansServicoApp
    {
        private readonly IClansRepositorioExterno _clansRepositorio;
        private readonly IMembrosClanRepositorioExterno _membrosRepositorio;

        public ClansServicoApp(IClansRepositorioExterno clansRepositorio, IMembrosClanRepositorioExterno membrosRepositorio)
        {
            _clansRepositorio = clansRepositorio;
            _membrosRepositorio = membrosRepositorio;
        }

        public void BuscarBarbarosWar()
        {
            _clansRepositorio.BuscarBarbarosWar();
        }

        public string BuscarMembrosBarbarosWar()
        {
            return _membrosRepositorio.BuscarMembrosBarbarosWar();
        }
    }
}
