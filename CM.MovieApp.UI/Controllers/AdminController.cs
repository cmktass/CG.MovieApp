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
        public IActionResult AddFilm()
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
            if(ModelState.IsValid)
            {
                return RedirectToAction("index", "home");
            }
            return View(actor);
        }

        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddCategory(CategoryModel categoryModel)
        {
            if (ModelState.IsValid)
            {
                await categoryService.Add(mapper.Map<Category>(categoryModel));
                return RedirectToAction("index", "home");
            }
            else
            {
                return View(categoryModel);
            }
           
        }
    }
}
