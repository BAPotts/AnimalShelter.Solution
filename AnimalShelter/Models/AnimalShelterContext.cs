using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
          : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, Name = "Frankie", Species = "Cat", Breed = "Domestic Shorthair", Age = 3, Gender = "Female"},
          new Animal { AnimalId = 2, Name = "Jasper", Species = "Cat", Breed = "Domestic Mediumhair", Age = 3, Gender = "Male"},
          new Animal { AnimalId = 3, Name = "Violet", Species = "Dog", Breed = "Puggle", Age = 8, Gender = "Female"},
          new Animal { AnimalId = 4, Name = "Snugglepuss", Species = "Cat", Breed = "Domestic Longhair", Age = 5, Gender = "Female"},
          new Animal { AnimalId = 5, Name = "Ella", Species = "Dog", Breed = "Terrier Mix", Age = 3, Gender = "Female"},
          new Animal { AnimalId = 6, Name = "Huckleberry", Species = "Dog", Breed = "Terrier Mix", Age = 10, Gender = "Male"},
          new Animal { AnimalId = 7, Name = "Bubsy", Species = "Cat", Breed = "Domestic Shorthair", Age = 5, Gender = "Male"},
          new Animal { AnimalId = 8, Name = "Toots", Species = "Cat", Breed = "Domestic Shorthair", Age = 7, Gender = "Female"},
          new Animal { AnimalId = 9, Name = "Rye", Species = "Dog", Breed = "Chesapeake Bay Retriever", Age = 7, Gender = "Male"},
          new Animal { AnimalId = 10, Name = "Scout", Species = "Cat", Breed = "Bombay", Age = 5, Gender = "Female"},
          new Animal { AnimalId = 11, Name = "Roger", Species = "Dog", Breed = "Great Dane", Age = 1, Gender = "Male"},
          new Animal { AnimalId = 12, Name = "Fido", Species = "Dog", Breed = "Wolfhound", Age = 6, Gender = "Female"},
          new Animal { AnimalId = 13, Name = "George", Species = "Cat", Breed = "Domestic Shorthair", Age = 14, Gender = "Male"},
          new Animal { AnimalId = 14, Name = "Russell", Species = "Dog", Breed = "Jack Russell Terrier", Age = 3, Gender = "Male"},
          new Animal { AnimalId = 15, Name = "Gypsy", Species = "Cat", Breed = "Domestic Shorthair", Age = 17, Gender = "Female"},
          new Animal { AnimalId = 16, Name = "Hank", Species = "Cat", Breed = "Siamese", Age = 4, Gender = "Male"},
          new Animal { AnimalId = 17, Name = "Jiji", Species = "Cat", Breed = "Domestic Shorthair", Age = 5, Gender = "Male"},
          new Animal { AnimalId = 18, Name = "Chance", Species = "Dog", Breed = "Boxer", Age = 1, Gender = "Male"},
          new Animal { AnimalId = 19, Name = "Sassy", Species = "Cat", Breed = "Ragdoll", Age = 8, Gender = "Female"},
          new Animal { AnimalId = 20, Name = "Shadow", Species = "Dog", Breed = "Golden Retriever", Age = 12, Gender = "Male"}
        );
    }

    public DbSet<Animal> Animals { get; set; }
  }
}