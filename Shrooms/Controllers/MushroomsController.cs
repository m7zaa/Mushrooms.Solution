using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Shrooms.Models;

namespace Shrooms.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MushroomsController : ControllerBase
    {

        private ShroomsContext _db;

        public MushroomsController(ShroomsContext db)
        {
          _db = db;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Mushroom> Get(int id)
        {
        return _db.Mushrooms.FirstOrDefault(entry => entry.MushroomId == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
