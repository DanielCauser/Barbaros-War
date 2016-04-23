using BARBAROS.APLICACAO;
using System.Web.Mvc;

namespace BARBAROS.MVC.Controllers
{
    public class AboutController : Controller
    {
        private readonly IClansServicoApp _buscarClans;

        public AboutController(IClansServicoApp buscarClans)
        {
            _buscarClans = buscarClans;
        }
        // GET: About
        public ActionResult Index()
        {
            return View();
        }
    }
}
