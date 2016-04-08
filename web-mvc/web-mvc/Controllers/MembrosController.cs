using BARBAROS.APLICACAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_mvc.Controllers
{
    public class MembrosController : Controller
    {
        private readonly IClansServicoApp _buscarClans;
        public MembrosController(IClansServicoApp buscarClans)
        {
            _buscarClans = buscarClans;
        }
        // GET: Membros
        public ActionResult Index()
        {
            return View();
        }
    }
}
