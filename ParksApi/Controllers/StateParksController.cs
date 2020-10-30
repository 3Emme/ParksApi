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
  public class StateParksController : ControllerBase
  {
    private ParksApiContext _db;

    public StateParksController(ParksApiContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult<IEnumerable<StatePark>> Get(string name)
    {
      var query = _db.StateParks.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.StateParkName == name);
      }
      
      return query.ToList();
    }

    [HttpPost]
    public void Post([FromBody] StatePark statePark, int StateId)
    {
      _db.StateParks.Add(statePark);
      if (StateId != 0)
      {
        _db.StateJoins.Add(new StateJoin() { StateId = StateId, StateParkId = statePark.StateParkId });
      }
      _db.SaveChanges();
    }

    [HttpGet("{id}")]
    public ActionResult<StatePark> Get(int id)
    {
      // return _db.StateParks.Include(statePark => statePark.User).FirstOrDefault(entry => entry.StateParkId == id);
      return _db.StateParks.FirstOrDefault(entry => entry.StateParkId == id);
    }


    [HttpPut("{id}")]
    public void Put(int id, [FromBody] StatePark statePark)
    {
      statePark.StateParkId = id;
      _db.Entry(statePark).State = EntityState.Modified;
      _db.SaveChanges();
    }
    
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var stateParkToDelete = _db.StateParks.FirstOrDefault(entry => entry.StateParkId == id);
      _db.StateParks.Remove(stateParkToDelete);
      _db.SaveChanges();
    }
  }
}