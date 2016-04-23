using BARBAROS.APLICACAO;
using System.Web.Mvc;

namespace BARBAROS.MVC.Controllers
{
    public class MembrosController : Controller
    {
        private readonly IClansServicoApp _buscarClans;

        public MembrosController(IClansServicoApp buscarClans)
        {
            _buscarClans = buscarClans;
        }
        // GET: Membros
        public JsonResult Index()
        {
            return Json(_buscarClans.BuscarMembrosBarbarosWar(), JsonRequestBehavior.AllowGet);
        }
    }
}
