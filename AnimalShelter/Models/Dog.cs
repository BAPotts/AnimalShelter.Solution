using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Models
{
  public class Dog
  {
    public int DogId { get; set; }
    [Required]
    [StringLength(30, ErrorMessage = "Please enter a name under 30 characters.")]
    public string Name { get; set; }
    [Required]
    public string Color { get; set; }
    [Required]
    public string Breed { get; set; }
    [Required]
    [Range(0, 40, ErrorMessage = "Please enter an age between 0 and 40.")]
    public int Age { get; set; }
    [Required]
    public string Gender { get; set; }
  }
}
