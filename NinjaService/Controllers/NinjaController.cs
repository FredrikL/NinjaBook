using System.Web.Mvc;
using NinjaService.App;
using NinjaService.Models;

namespace NinjaService.Controllers
{
    public class NinjaController : Controller
    {
        private IAllNinjas allNinjas;

        public NinjaController(IAllNinjas allNinjas)
        {
            this.allNinjas = allNinjas;
        }

        //
        // GET: /Njnja/
        [HttpGet]
        public ActionResult Index()
        {
            var ninjas = this.allNinjas.GetAll();
            return new JsonpResult{ Data = ninjas, JsonRequestBehavior = JsonRequestBehavior.AllowGet};
        }

        [HttpGet]
        public ActionResult Details(string nickname)
        {
            var ninja = this.allNinjas.GetByNickName(nickname);
            return new JsonpResult { Data = ninja, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        [HttpPost]
        public ActionResult Edit(Ninja ninja)
        {
            var updatedNinja = this.allNinjas.Edit(ninja);
            return new JsonpResult { Data = updatedNinja};
        }
    }
}
