using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;  
using BestRestaurants.Models;

namespace BestRestaurants.Controllers
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