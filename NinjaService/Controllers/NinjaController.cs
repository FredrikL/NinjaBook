using System.Web.Mvc;
using NinjaService.App;
using NinjaService.Models;

namespace NinjaService.Controllers
{
    public class NinjaController : Controller
    {
        private IAllNinjas AllNinjas;

        public NinjaController(IAllNinjas allNinjas)
        {
            this.AllNinjas = allNinjas;
        }

        //
        // GET: /Njnja/
        [HttpGet]
        public JsonResult Index()
        {
            var ninjas = this.AllNinjas.GetAll();
            return Json(ninjas, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Edit(Ninja ninja)
        {
            var updatedNinja = this.AllNinjas.Edit(ninja);
            return Json(updatedNinja);
        }
    }
}
