using AutoMapper;
using CG.MovieApp.Business.Interfaces;
using CG.MovieApp.UI.Models;
using CG.MovieAppEntity.Entities;
using CM.MovieApp.UI.Mapping.AutoMapping;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CM.MovieApp.UI.Controllers
{
    public class AdminController : Controller
    {
        private IMapper mapper;
        private ICategoryService categoryService;
        private IActorService actorService;
        private IDirectorService directorService;
        private IFilmService filmService;
        
        public AdminController(IMapper mapper,ICategoryService categoryService,IActorService actorService,IDirectorService directorService,IFilmService filmService)
        {
            this.mapper = mapper;
            this.categoryService = categoryService;
            this.actorService=actorService;
            this.directorService=directorService;
            this.filmService=filmService;
        }

        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(CategoryModel category)
        {
            if (ModelState.IsValid)
            {
                categoryService.Add(mapper.Map<Category>(category));
                return RedirectToAction("index", "home");
            }
            return View(category);
        }


        public async Task<IActionResult> AddFilm()
        {
            var allCategory=await categoryService.GetAll();
            ViewBag.AllCategory=allCategory;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddFilm(FilmModel film)
        {
            var allCategory=await categoryService.GetAll();
            ViewBag.AllCategory=allCategory;
            return View();
        }



        public IActionResult AddActor()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddActor(ActorModel actor)
        {
            if (ModelState.IsValid)
            {
                actorService.Add(mapper.Map<Actor>(actor));
                return RedirectToAction("index", "home");
            }
            return View(actor);
        }

        public IActionResult getActorName(string actorName)
        {
             var actor= actorService.GetByName(actorName);
              var jsonKulanıcılar=JsonConvert.SerializeObject(actor);
             if(actor!=null){
                 return Json(true);
             }
             else{
                  return Json(false);
             }
        }
    



        public IActionResult AddDirector()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDirector(DirectorModel director)
        {
            if(ModelState.IsValid)
            {
                directorService.Add(mapper.Map<Director>(director));
                RedirectToAction("index","home");
            }
            return View(director);
        }
    }
}
