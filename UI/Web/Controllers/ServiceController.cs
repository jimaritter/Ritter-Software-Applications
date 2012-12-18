using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StaticConsulting.Model.Services;

namespace StaticConsulting.Web.Controllers
{
    public class ServiceController : Controller
    {
        private IService _service;

        public ServiceController(IService service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            var ret = _service.Services();
            return View(ret);
        }

        public ActionResult Details(int id)
        {
            var service = _service.Services().Single(x => x.Id == id);
            return View(service);
        }

    }
}
