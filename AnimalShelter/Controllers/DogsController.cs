using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DogsController : ControllerBase
  {
    private AnimalShelterContext _db;

    public DogsController(AnimalShelterContext db)
    {
      _db = db;
    }

    [HttpGet("page")] //GET api/dogs/page/?pageNumber=1&pageSize=2
    public ActionResult GetPages([FromQuery] UrlQuery urlQuery)
    {
      var validUrlQuery = new UrlQuery(urlQuery.PageNumber, urlQuery.PageSize);
      var pagedData = _db.Dogs
                .OrderBy(dog => dog.DogId)
                .Skip((validUrlQuery.PageNumber -1) * validUrlQuery.PageSize)
                .Take(validUrlQuery.PageSize);
      return Ok(pagedData);
    }

    [HttpGet] //GET api/dogs
    public ActionResult<IEnumerable<Dog>> Get(string name, string color, string breed, int? age, string gender)
    {
      var query = _db.Dogs.AsQueryable();
      
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

    [HttpPost] //POST api/dogs
    public void Post([FromBody] Dog dog)
    {
      _db.Dogs.Add(dog);
      _db.SaveChanges();
    }

    [HttpGet("{id}")] //GET api/dogs/5
    public ActionResult<Dog> Get(int id)
    {
      return _db.Dogs.FirstOrDefault(entry => entry.DogId ==id);
    }

    [HttpPut("{id}")] //PUT api/dogs/5
    public void Put(int id, [FromBody] Dog dog)
    {
      dog.DogId = id;
      _db.Entry(dog).State = EntityState.Modified;
      _db.SaveChanges();
    }

    [HttpGet("random")]//GET api/dogs/random
    public ActionResult<Dog> GetRandom()
    {
      System.Random random = new System.Random(); 
      int id = random.Next(1,11);
      return _db.Dogs.FirstOrDefault(entry => entry.DogId ==id);
    }

    [HttpDelete("{id}")]//DELETE api/dogs/5
    public void Delete(int id)
    {
      var dogToDelete = _db.Dogs.FirstOrDefault(entry => entry.DogId ==id);
      _db.Dogs.Remove(dogToDelete);
      _db.SaveChanges();
    }
  }
}