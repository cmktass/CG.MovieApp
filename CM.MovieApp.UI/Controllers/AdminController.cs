using AutoMapper;
using CG.MovieApp.Business.Interfaces;
using CG.MovieApp.UI.Models;
using CG.MovieAppEntity.Entities;
using CM.MovieApp.UI.Mapping.AutoMapping;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CM.MovieApp.UI.Controllers
{
    public class AdminController : Controller
    {
        private ICategoryService categoryService;
        private IMapper mapper;
        public AdminController(ICategoryService categoryService,IMapper mapper)
        {
            this.categoryService = categoryService;
            this.mapper = mapper;
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
        public IActionResult AddFilm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddFilm(int i)
        {
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
                return RedirectToAction("index", "home");
            }
            return View(actor);
        }
        public IActionResult AddDirector()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDirector(DirectorModel director)
        {
            return View();
        }

        
    }
}
