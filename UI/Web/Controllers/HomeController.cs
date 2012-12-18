using System.Web.Mvc;
using StaticConsulting.Model.Products;
using StaticConsulting.Web.Infrastructure;

namespace StaticConsulting.Web.Controllers
{
    public class HomeController : Controller
    {
        private IProduct _productdb;

        public HomeController(IProduct productdb)
        {
            _productdb = productdb;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Product()
        {
            var products = _productdb.Products();
            return View(products);
        }
    }
}
