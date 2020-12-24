using CG.MovieApp.Business.Interfaces;
using CG.MovieApp.DataAccess.Interfaces.Dal;
using CG.MovieAppEntity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CG.MovieApp.Business.Concrete
{
    public class CategoryService:GenericService<Category>,ICategoryService
    {
        public CategoryService(IGenericDal<Category> genericDal):base(genericDal)
        {

        }
    }
}
