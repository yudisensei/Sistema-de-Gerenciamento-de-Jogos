using ManagementSystemOfGames.Models;
using ManagerSystemOfGames.Units;
using System.Web.Mvc;

namespace ManagerSystemOfGames.Controllers
{
    public class GenderController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();


        public ActionResult List() {
            var lista = _unit.GenderRepository.List();
            return View(lista);
        }

        [HttpPost]
        public ActionResult RegisterGender(Gender gender) {
            _unit.GenderRepository.Register(gender);
            _unit.Save();
            TempData["msg"] = "Gender Registered with success!";
            return RedirectToAction("List");
        }

        [HttpGet]
        // GET: Gender
        public ActionResult RegisterGender()
        {
            return View();
        }

        // Release all resources allocation
        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}