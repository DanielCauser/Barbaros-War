using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BARBAROS.IOC
{
    public class RegistradorDeIoc
    {
        public Container _container { get; set; }

        public RegistradorDeIoc()
        {
            _container = new Container();
        }

        public Container Registrador()
        {
             _container = new InjecaoAplicacaoIoc().Registrar(_container);

            _container = new InjecaoRepositorioIoc().Registrar(_container);

            _container.Verify();

            return _container;
        }
    }
}
