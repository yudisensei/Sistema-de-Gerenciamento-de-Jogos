using ManagementSystemOfGames.Models;
using ManagerSystemOfGames.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManagerSystemOfGames.Controllers
{
    public class GameController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();

        [HttpPost]
        public ActionResult RemoveGame(int gameId) {
            _unit.GameRepository.Delete(gameId);
            _unit.Save();
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult UpdateGame(Game game) {
            _unit.GameRepository.Update(game);
            _unit.Save();
            TempData["msg"] = "Game updated with success !";
            return RedirectToAction("List");
        }

        [HttpPost]
        public ActionResult RegisterGame(Game game) {
            _unit.GameRepository.Register(game);
            _unit.Save();
            TempData["msg"] = "Game register with success !";
            return RedirectToAction("List");
        }

        [HttpGet]
        // GET: Game
        public ActionResult RegisterGame()
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