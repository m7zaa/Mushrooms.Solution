using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Shrooms.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System;

namespace Shrooms.Controllers
{
  //requires token
  // [Authorize]
  [Route("api/[controller]")]
  [ApiController]
  public class MushroomsController : ControllerBase
  {
    private ShroomsContext _db;

    public MushroomsController(ShroomsContext db)
    {
      _db = db;
    }

    // GET api/Mushrooms
    [AllowAnonymous]
    [HttpGet]
    public ActionResult<IEnumerable<Mushroom>> Get(string flex, string name, string family, bool psycho, bool poisonous, string region, string sporePrintDetails, string visualDetails, int capDimensions, int stemDimensions)
    {
      var query = _db.Mushrooms.AsQueryable();
      Console.WriteLine(poisonous);

      if (flex != null)
      {
        flex = flex.ToLower();
        query = query.Where(entry => entry.Name.ToLower().Contains(flex) || entry.Family.ToLower().Contains(flex) || entry.Psycho && flex.Contains("sycho") || entry.Poisonous && flex.Contains("oison") || entry.Region.ToLower().Contains(flex) || entry.SporePrintDetails.ToLower().Contains(flex) || entry.VisualDetails.ToLower().Contains(flex) || entry.CapDimensions.Equals(flex) || entry.StemDimensions.Equals(flex));


        return query.ToList();
      } 
      
      else
    



      if (name != null)
      {
        query = query.Where(entry => entry.Name.ToLower().Contains(name.ToLower()));
      }

      if (family != null)
      {
        query = query.Where(entry => entry.Family.ToLower().Contains(family.ToLower()));
      }

      if (poisonous != false)
      {
        query = query.Where(entry => entry.Poisonous == poisonous);
      }
      if (psycho != false)
      {
        query = query.Where(entry => entry.Psycho == psycho);
      }
      if (region != null)
      {
        query = query.Where(entry => entry.Region.ToLower().Contains(region.ToLower()));
      }
      if (sporePrintDetails != null)
      {
        query = query.Where(entry => entry.SporePrintDetails.ToLower().Contains(sporePrintDetails.ToLower()));
      }
      if (visualDetails != null)
      {
        query = query.Where(entry => entry.VisualDetails.ToLower().Contains(visualDetails.ToLower()));
      }
      if (capDimensions != 0)
      {
        query = query.Where(entry => entry.CapDimensions == capDimensions);
      }
      if (stemDimensions != 0)
      {
        query = query.Where(entry => entry.StemDimensions == stemDimensions);
      }

      return query.ToList();
    }









    // POST api/Mushrooms
    [HttpPost]
    public void Post([FromBody] Mushroom mushroom)
    {
      _db.Mushrooms.Add(mushroom);
      _db.SaveChanges();
    }

    // GET api/animals/5
    [HttpGet("{id}")]
    public ActionResult<Mushroom> Get(int id)
    {
      return _db.Mushrooms.FirstOrDefault(entry => entry.MushroomId == id);
    }

    // PUT api/animals/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Mushroom mushroom)
    {
      mushroom.MushroomId = id;
      _db.Entry(mushroom).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/Mushrooms/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var mushroomToDelete = _db.Mushrooms.FirstOrDefault(entry => entry.MushroomId == id);
      _db.Mushrooms.Remove(mushroomToDelete);
      _db.SaveChanges();
    }
  }
}