using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BARBAROS.IOC
{
    public interface IRegistrador
    {
        Container Registrar(Container _container);
    }
}
