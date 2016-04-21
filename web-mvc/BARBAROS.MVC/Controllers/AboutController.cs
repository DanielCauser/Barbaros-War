using BARBAROS.APLICACAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace web_mvc.Controllers
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
