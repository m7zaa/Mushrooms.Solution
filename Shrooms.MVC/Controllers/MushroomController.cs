  using System.Collections.Generic;
  using System.Linq;
  using System;
  using Microsoft.AspNetCore.Authorization;
  using Microsoft.AspNetCore.Mvc.Rendering;
  using Microsoft.AspNetCore.Mvc;
  using Microsoft.EntityFrameworkCore;
  using Shrooms.Models;

  namespace Shrooms.Controllers {
      public class MushroomsController : Controller {
          public IActionResult Index () {
              var mushroomList = Mushroom.MushroomList ();
              return View (mushroomList);
          }

          [HttpGet ("Mushrooms/{id}")]
          public ActionResult Details (int id) {

              Mushroom thisMushroom = Mushroom.MushroomDetails (id);
              return View (thisMushroom);
          }

          [HttpGet]
          public ActionResult Create () {
              return View ();
          }

          [HttpPost]
          public ActionResult Create (Mushroom mushroom) {
              mushroom.MushroomCreate ();
              return RedirectToAction ("Index");
          }

          [HttpGet]
          public ActionResult Delete (int id, string name) {
              ViewBag.name = name;
              ViewBag.id = id;
              return View ();
          }

          [HttpPost, ActionName ("Delete")]
          public ActionResult Delete (int id) {
              Mushroom.MushroomDelete (id);
              return RedirectToAction ("Index");
          }

          [HttpGet]
          public ActionResult Edit (int id) {
              var mushroom = Mushroom.MushroomDetails (id);
              return View (mushroom);
          }

          [HttpPost]
          public ActionResult Edit (Mushroom mushroom) {
            Mushroom.MushroomEdit (mushroom);
            return RedirectToAction ("Index");
          }

      }
  }