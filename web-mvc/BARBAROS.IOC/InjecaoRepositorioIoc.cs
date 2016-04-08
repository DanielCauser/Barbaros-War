using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleInjector;
using BARBAROS.REPOSITORIO_EXTERNO;

namespace BARBAROS.IOC
{
    class InjecaoRepositorioIoc : IRegistrador
    {
        public Container Registrar(Container _container)
        {
            _container.Register<IClansRepositorioExterno, ClansRepositorioExterno>(Lifestyle.Transient);
            _container.Register<IMembrosClanRepositorioExterno, MembrosClanRepositorioExterno>(Lifestyle.Transient);

            return _container;
        }
    }
}
