using Microsoft.AspNetCore.Mvc;
using SevenBridgeAMCProj.Models;

namespace SevenBridgeAMCProj.Controllers
{
    public class SevenBridgeAMCController : Controller
    {
        private SevenBridgeAMCContext context { get; set; }
        public SevenBridgeAMCController(SevenBridgeAMCContext ctx) => context = ctx;
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new SevenBridgeAMC());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var movie = context.SevenBridges.Find(id);
            return View(movie);
        }
        [HttpPost]
        public IActionResult Edit(SevenBridgeAMC sevenBridgeAMC)
        {
            if (ModelState.IsValid)
            {
                if (sevenBridgeAMC.MovieId == 0)
                {
                    context.SevenBridges.Add(sevenBridgeAMC);
                    TempData["SuccessMessage"] = sevenBridgeAMC.Name + "Movie Added Successfully";
                }


                else
                {
                    context.SevenBridges.Update(sevenBridgeAMC);
                    TempData["SuccessMessage"] = sevenBridgeAMC.Name + "Movie Updated Successfully";
                }
                    
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (sevenBridgeAMC.MovieId == 0) ? "Add" : "Edit";
                return View(sevenBridgeAMC);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var movie = context.SevenBridges.Find(id);
            TempData["SuccessMessage"] = movie?.Name + "Movie Deleted Successfully";
            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(SevenBridgeAMC sevenBridgeAMC)
        {
            //TempData["SuccessMessage"] = sevenBridgeAMC.Name + "Movie Deleted Successfully";
            context.SevenBridges.Remove(sevenBridgeAMC);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
