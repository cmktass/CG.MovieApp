using CG.MovieApp.Business.Interfaces;
using CG.MovieAppEntity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CM.MovieApp.UI.Controllers
{
    public class HomeController : Controller
    {
       
        public HomeController(IFilmService filmService)
        {
           
        }
        
        public IActionResult Index(Film film)
        {
            
            return View();
        }

    }
}
