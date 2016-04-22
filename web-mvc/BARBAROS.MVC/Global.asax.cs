using BARBAROS.IOC;
using BARBAROS.MVC;
using BARBAROS.MVC.App_Start;
using BARBAROS.REPOSITORIO.Context;
using BARBAROS.REPOSITORIO.Inicializador;
using SimpleInjector.Integration.Web.Mvc;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace web_mvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            
            var container = new RegistradorDeIoc().Registrador();
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}
