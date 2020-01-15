using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace AnimalShelter.Models
{
  public class Pets
  {
    public int Id { get; set; }
    public string AnimalType { get; set; }
    public string Name { get; set; }
    public string Gender{ get; set; }
    public string DateOfAdmittance { get; set; }
    public string Breed { get; set; }
  }
}