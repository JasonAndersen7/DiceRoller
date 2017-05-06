using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DiceRollerBiz;
using Logging;
namespace DiceRoller.Controllers
{
    public class DiceController : Controller
    {
        // GET: Dice
        public ActionResult Index()
        {
            Logger.LogMessage("Entering Dice Controller", "Debug");
            
            IDiceRollerBiz dice = new DiceRollerBiz.DiceRollerBiz();

            var result = dice.RollTwoDice(6);
            Logger.LogMessage(string.Format("Passed in value: {0} to view ", result), "Debug");

            return View(result);
        }
        // GET: All Dice Rolls  
        [HttpGet]
        public JsonResult RollDice(int max = 6)
        {
            DiceRollerModels.Die dieResults = new DiceRollerModels.Die();
            try
            {
                Logger.LogMessage("Entering Dice Controller", "Debug");

                IDiceRollerBiz dice = new DiceRollerBiz.DiceRollerBiz();

                dieResults = dice.RollTwoDice(max);

                Logger.LogMessage(string.Format("Passed in value: {0} to view ", dieResults), "Debug");
            }
            catch
            {

            }
            return Json(dieResults.ToList(), JsonRequestBehavior.AllowGet);
        }





        //// GET: Dice/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: Dice/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Dice/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Dice/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Dice/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Dice/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Dice/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
