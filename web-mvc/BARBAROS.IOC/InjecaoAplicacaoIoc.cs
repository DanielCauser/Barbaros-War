using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleInjector;
using BARBAROS.APLICACAO;

namespace BARBAROS.IOC
{
    class InjecaoAplicacaoIoc : IRegistrador
    {
        public Container Registrar(Container _container)
        {
            _container.Register<IClansServicoApp, ClansServicoApp>(Lifestyle.Transient);
            return _container;
        }
    }
}
