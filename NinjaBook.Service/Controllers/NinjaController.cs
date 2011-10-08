namespace NinjaBook.Service.Controllers
{
    using System.Web.Mvc;
    using Models;
    using NinjaBook.Service.App;

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
        public JsonResult Index()
        {
            var ninjas = this.allNinjas.GetAll();
            return Json(ninjas, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult Details(string nickname)
        {
            var ninja = this.allNinjas.GetByNickName(nickname);
            return Json(ninja, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Edit(Ninja ninja)
        {
            var updatedNinja = this.allNinjas.Edit(ninja);
            return Json(updatedNinja);
        }
    }
}
