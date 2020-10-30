using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ParksApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace ParksApi.Controllers
{
  [Authorize]
  [Route("api/[controller]")]
  [ApiController]
  public class NationalParksController : ControllerBase
  {
    private ParksApiContext _db;

    public NationalParksController(ParksApiContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult<IEnumerable<NationalPark>> Get(string name)
    {
      var query = _db.NationalParks.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.NationalParkName == name);
      }
      
      return query.ToList();
    }

    [HttpPost]
    public void Post([FromBody] NationalPark nationalPark, int StateId)
    {
      _db.NationalParks.Add(nationalPark);
      if (StateId != 0)
      {
        _db.StateJoins.Add(new StateJoin() { StateId = StateId, NationalParkId = nationalPark.NationalParkId });
      }
      _db.SaveChanges();
    }

    [HttpGet("{id}")]
    public ActionResult<NationalPark> Get(int id)
    {
      // return _db.NationalParks.Include(nationalPark => nationalPark.User).FirstOrDefault(entry => entry.NationalParkId == id);
      return _db.NationalParks.FirstOrDefault(entry => entry.NationalParkId == id);
    }


    [HttpPut("{id}")]
    public void Put(int id, [FromBody] NationalPark nationalPark)
    {
      nationalPark.NationalParkId = id;
      _db.Entry(nationalPark).State = EntityState.Modified;
      _db.SaveChanges();
    }
    
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var nationalParkToDelete = _db.NationalParks.FirstOrDefault(entry => entry.NationalParkId == id);
      _db.NationalParks.Remove(nationalParkToDelete);
      _db.SaveChanges();
    }
  }
}