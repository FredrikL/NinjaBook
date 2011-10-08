using System.Web.Mvc;
using NinjaService.Models;

namespace NinjaService.Controllers
{
    public class NinjaController : Controller
    {
        //
        // GET: /Njnja/
        public JsonResult Index()
        {
            var ninjas = new[] {new Ninja() {Name = "Ninja Ninjasson", Phone = "0701 13 13 13"}};
            return Json(ninjas, JsonRequestBehavior.AllowGet);
        }
    }
}
