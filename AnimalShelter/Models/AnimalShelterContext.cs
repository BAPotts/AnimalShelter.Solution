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
      builder.Entity<Cat>()
        .HasData(
          new Cat { CatId = 1, Name = "Frankie", Color = "Black", Breed = "Domestic Shorthair", Age = 3, Gender = "Female"},
          new Cat { CatId = 2, Name = "Jasper", Color = "Black", Breed = "Domestic Mediumhair", Age = 3, Gender = "Male"},
          new Cat { CatId = 3, Name = "Snugglepuss", Color = "Tabby", Breed = "Domestic Longhair", Age = 5, Gender = "Female"},
          new Cat { CatId = 4, Name = "Bubsy", Color = "Tabby", Breed = "Domestic Shorthair", Age = 5, Gender = "Male"},
          new Cat { CatId = 5, Name = "Toots", Color = "Grey", Breed = "Domestic Shorthair", Age = 7, Gender = "Female"},
          new Cat { CatId = 6, Name = "Scout", Color = "Calico", Breed = "Bombay", Age = 5, Gender = "Female"},
          new Cat { CatId = 7, Name = "George", Color = "White", Breed = "Domestic Shorthair", Age = 14, Gender = "Male"},
          new Cat { CatId = 8, Name = "Gypsy", Color = "Black", Breed = "Domestic Shorthair", Age = 17, Gender = "Female"},
          new Cat { CatId = 9, Name = "Hank", Color = "Orange", Breed = "Siamese", Age = 4, Gender = "Male"},
          new Cat { CatId = 10, Name = "Jiji", Color = "Black", Breed = "Domestic Shorthair", Age = 5, Gender = "Male"},
          new Cat { CatId = 11, Name = "Sassy", Color = "Flame Point", Breed = "Ragdoll", Age = 8, Gender = "Female"}
          );
      builder.Entity<Dog>()
        .HasData(
          new Dog { DogId = 1, Name = "Violet", Color = "Black", Breed = "Puggle", Age = 8, Gender = "Female"},
          new Dog { DogId = 2, Name = "Ella", Color = "Grey", Breed = "Terrier Mix", Age = 3, Gender = "Female"},
          new Dog { DogId = 3, Name = "Huckleberry", Color = "Brown", Breed = "Terrier Mix", Age = 10, Gender = "Male"},
          new Dog { DogId = 4, Name = "Rye", Color = "Brown", Breed = "Chesapeake Bay Retriever", Age = 7, Gender = "Male"},
          new Dog { DogId = 5, Name = "Roger", Color = "White", Breed = "Great Dane", Age = 1, Gender = "Male"},
          new Dog { DogId = 6, Name = "Fido", Color = "Tawny", Breed = "Wolfhound", Age = 6, Gender = "Female"},
          new Dog { DogId = 7, Name = "Russell", Color = "Spotted", Breed = "Jack Russell Terrier", Age = 3, Gender = "Male"},
          new Dog { DogId = 8, Name = "Chance", Color = "Pink", Breed = "Boxer", Age = 1, Gender = "Male"},
          new Dog { DogId = 9, Name = "Shadow", Color = "Gold", Breed = "Golden Retriever", Age = 12, Gender = "Male"},
          new Dog { DogId = 10, Name = "Jake", Color = "Brown", Breed = "Chesapeake Bay Retriever", Age = 2, Gender = "Male"}
        );
    }

    public DbSet<Cat> Cats { get; set; }
    public DbSet<Dog> Dogs { get; set; }
  }
}