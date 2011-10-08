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
            
            return Json(new Ninja(){Name ="Ninja Ninjasson", Phone = "0701 13 13 13"}, JsonRequestBehavior.AllowGet);
        }

    }
}
