using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace DiceRollerWeb.Controllers
{
    public class DiceController : Controller
    {
        // GET: Dice
        public ActionResult Roll(int sides = 6)
        {
            var _roll = new DiceRollerLogic.DiceRoller().RollDice(sides);
            ViewBag.Result = _roll;
            return View("Index");
        }
    }
}