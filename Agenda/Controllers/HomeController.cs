using Agenda.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Agenda.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEvenimentManager _evenimentManager = null;
        private readonly IPacientManager _pacientManager = null;

        public HomeController(IEvenimentManager evenimentManager, IPacientManager pacientManager)
        {
            _evenimentManager = evenimentManager;
            _pacientManager = pacientManager;
        }   
        // GET: Home
        public ActionResult Index()
        {
            List<Eveniment> events = _evenimentManager.All();
            return View(events);
        }
        public ActionResult CreateEvt()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateEvt(EvenimentDto model)
        {
            if (model != null)
            {
                _evenimentManager.Insert(model);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}