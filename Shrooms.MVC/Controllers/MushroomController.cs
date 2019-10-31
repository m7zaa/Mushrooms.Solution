  using System.Collections.Generic;
  using System.Linq;
  using System.Threading.Tasks;
  using System;
  using Microsoft.AspNetCore.Authorization;
  using Microsoft.AspNetCore.Mvc.Rendering;
  using Microsoft.AspNetCore.Mvc;
  using Microsoft.EntityFrameworkCore;
  using Shrooms.Models;

  namespace Shrooms.Controllers {
      public class MushroomsController : Controller {

        //   public IActionResult Index () {
        //       var mushroomList = Mushroom.MushroomList ();
        //       return View (mushroomList);
        //   }

          public IActionResult Index (string search) {
              var mushroomList = Mushroom.MushroomListSearch (search);
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
          public async Task<IActionResult> Create (Mushroom mushroom) {
              await mushroom.MushroomCreate ();
              return RedirectToAction ("Index");
          }

          [HttpGet]
          public ActionResult Delete (int id, string name) {
              var mushroom = Mushroom.MushroomDetails (id);
              return View (mushroom);
          }

          [HttpPost, ActionName ("Delete")]
          public async Task<IActionResult> Delete (int id) {
              await Mushroom.MushroomDelete (id);
              return RedirectToAction ("Index");
          }

          [HttpGet]
          public ActionResult Edit (int id) {
              var mushroom = Mushroom.MushroomDetails (id);
              return View (mushroom);
          }

          [HttpPost]
          public async Task<IActionResult> Edit (Mushroom mushroom) {
              await Mushroom.MushroomEdit (mushroom);
              return RedirectToAction ("Index");
          }
      }
  }