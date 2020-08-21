using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private AnimalShelterContext _db;

    public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }

    [HttpGet] //GET api/animals
    public ActionResult<IEnumerable<Animal>> Get(string name, string species, string breed, int? age, string gender)
    {
      var query = _db.Animals.AsQueryable();
      
      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (species != null)
      {
        query = query.Where(entry => entry.Species == species);
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

    [HttpPost] //POST api/animals
    public void Post([FromBody] Animal animal)
    {
      _db.Animals.Add(animal);
      _db.SaveChanges();
    }

    [HttpGet("{id}")] //GET api/animals/5
    public ActionResult<Animal> Get(int id)
    {
      return _db.Animals.FirstOrDefault(entry => entry.AnimalId ==id);
    }

    [HttpPut("{id}")] //PUT api/animals/5
    public void Put(int id, [FromBody] Animal animal)
    {
      animal.AnimalId = id;
      _db.Entry(animal).State = EntityState.Modified;
      _db.SaveChanges();
    }

    [HttpDelete("{id}")]//DELETE api/animals/5
    public void Delete(int id)
    {
      var animalToDelete = _db.Animals.FirstOrDefault(entry => entry.AnimalId ==id);
      _db.Animals.Remove(animalToDelete);
      _db.SaveChanges();
    }
  }
}