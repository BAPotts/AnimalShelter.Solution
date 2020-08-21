using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CatsController : ControllerBase
  {
    private AnimalShelterContext _db;

    public CatsController(AnimalShelterContext db)
    {
      _db = db;
    }

    [HttpGet("page")] //GET api/dogs/page/?pageNumber=1&pageSize=2
    public ActionResult GetPages([FromQuery] UrlQuery urlQuery)
    {
      var validUrlQuery = new UrlQuery(urlQuery.PageNumber, urlQuery.PageSize);
      var pagedData = _db.Cats
                .OrderBy(cat => cat.CatId)
                .Skip((validUrlQuery.PageNumber -1) * validUrlQuery.PageSize)
                .Take(validUrlQuery.PageSize);
      return Ok(pagedData);
    }

    [HttpGet] //GET api/cats
    public ActionResult<IEnumerable<Cat>> Get(string name, string color, string breed, int? age, string gender)
    {
      var query = _db.Cats.AsQueryable();
      
      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (color != null)
      {
        query = query.Where(entry => entry.Color == color);
      }

      if (breed != null)
      {
        query = query.Where(entry => entry.Breed == name);
      }

      if (age != null)
      {
        query = query.Where(entry => entry.Age == age);
      }

      if(gender != null)
      {
        query = query.Where(entry => entry.Gender == gender);
      }
      return query.ToList();
    }

    [HttpPost] //POST api/cats
    public void Post([FromBody] Cat cat)
    {
      _db.Cats.Add(cat);
      _db.SaveChanges();
    }

    [HttpGet("{id}")] //GET api/cats/5
    public ActionResult<Cat> Get(int id)
    {
      return _db.Cats.FirstOrDefault(entry => entry.CatId ==id);
    }

    [HttpPut("{id}")] //PUT api/cats/5
    public void Put(int id, [FromBody] Cat cat)
    {
      cat.CatId = id;
      _db.Entry(cat).State = EntityState.Modified;
      _db.SaveChanges();
    }

    [HttpDelete("{id}")]//DELETE api/cats/5
    public void Delete(int id)
    {
      var catToDelete = _db.Cats.FirstOrDefault(entry => entry.CatId ==id);
      _db.Cats.Remove(catToDelete);
      _db.SaveChanges();
    }
  }
}