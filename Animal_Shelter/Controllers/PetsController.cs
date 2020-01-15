using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using System.Collections.Generic;
using System.Linq;
using AnimalShelter;

namespace AnimalShelter.Controllers
{
  public class PetsController : Controller
  {
    private readonly AnimalShelterContext _db;

    public PetsController(AnimalShelterContext db)
    {
      _db = db;
    } 
    public ActionResult Index()
    {
      List<Pets> model = _db.Pets.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Pets pet)
    {
      _db.Pets.Add(pet);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      Pets thisPet = _db.Pets.FirstOrDefault(pets => pets.Id == id);
      return View(thisPet);
    }
  }
}  