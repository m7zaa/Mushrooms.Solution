  
using Microsoft.AspNetCore.Mvc;
using Shrooms.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using System;


namespace Shrooms.Controllers
{
   
    public class MushroomssController : Controller
    {
        public ActionResult Index()
        {
            //make a place to stro the mushrooms
            List<Mushroom> model;

            //get the mushrooms from the api
            model = Mushroom.MushroomList();

            //pass the mushrooms to a view
            
            return View(model);
        }
    }


    //     // public async Task<ActionResult> Index()
    //     // {
    //     //     var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
    //     //     var currentUser = await _userManager.FindByIdAsync(userId);
    //     //     var userMushrooms = _db.Mushrooms.Where(entry => entry.User.Id == currentUser.Id);
    //     //     return View(userMushrooms);
    //     // }
    //     public ActionResult Create()
    //     {
    //         return View();
    //     }

    //     [HttpPost]
    //     public ActionResult Create(Mushroom mushroom)
    //     {
    //         _db.Mushrooms.Add(mushroom);
    //         _db.SaveChanges();
    //         return RedirectToAction("Index");
    //     }

    //     public ActionResult Details(int id)
    //     {
    //         var thisMushroom = _db.Mushrooms
    //             .Include(mushroom => mushroom.Treats)
    //             .ThenInclude(join => join.Treat)
    //             .FirstOrDefault(Mushroom => Mushroom.MushroomId == id);
    //         return View(thisMushroom);
    //     }

    //     [HttpPost]
    //     public ActionResult Index(string search)
    //     {
    //         List<Mushroom> model = _db.Mushrooms.ToList();
    //         if (!String.IsNullOrEmpty(search))
    //         {
    //             model = model.Where(mushroom => mushroom.MushroomName.ToLower().Contains(search.ToLower())).Select(mushroom => mushroom).ToList();
    //         }
    //         return View(model);
    //     }


    //     public ActionResult Edit(int id)
    //     {
    //         var thisMushroom = _db.Mushrooms.FirstOrDefault(mushroom => mushroom.MushroomId == id);
    //         return View(thisMushroom);
    //     }

    //     [HttpPost]
    //     public ActionResult Edit(Mushroom mushroom)
    //     {
    //         _db.Entry(mushroom).State = EntityState.Modified;
    //         _db.SaveChanges();
    //         return RedirectToAction("Index");
    //     }


    //     public ActionResult AddTreat(int id)
    //     {
    //         var thisMushroom = _db.Mushrooms.FirstOrDefault(mushrooms => mushrooms.MushroomId == id);
    //         ViewBag.TreatId = new SelectList(_db.Treats, "TreatId", "TreatName");
    //         return View(thisMushroom);
    //     }
    //     [HttpPost]
    //     public ActionResult AddTreat(Mushroom mushroom, int TreatId)
    //     {
    //         if (TreatId != 0)
    //         {
    //             _db.MushroomTreats.Add(new MushroomTreat() { TreatId = TreatId, MushroomId = mushroom.MushroomId });
    //         }
    //         _db.SaveChanges();
    //         return RedirectToAction("Index");
    //     }
    //     public ActionResult Delete(int id)
    //     {
    //         var thisMushroom = _db.Mushrooms.FirstOrDefault(mushroom => mushroom.MushroomId == id);
    //         return View(thisMushroom);
    //     }

    //     [HttpPost, ActionName("Delete")]
    //     public ActionResult DeleteConfirmed(int id)
    //     {
    //         var thisMushroom = _db.Mushrooms.FirstOrDefault(mushroom => mushroom.MushroomId == id);
    //         _db.Mushrooms.Remove(thisMushroom);
    //         _db.SaveChanges();
    //         return RedirectToAction("Index");
    //     }
}
