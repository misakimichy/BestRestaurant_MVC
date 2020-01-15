using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;  
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
  public class HomeController : Controller
  {
   [Route("/")]
   public ActionResult Index()
   {
     return View();
   }
  }
}