using AutoMapper;
using CG.MovieApp.UI.Models;
using CG.MovieAppEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CM.MovieApp.UI.Mapping.AutoMapping
{
    public class AutoMap:Profile
    {
        public AutoMap()
        {
            CreateMap<Film, FilmModel>();
            CreateMap<FilmModel, Film>();

            CreateMap<Actor, ActorModel>();
            CreateMap<ActorModel, Actor>();

            CreateMap<Director, DirectorModel>();
            CreateMap<DirectorModel, Director>();

            CreateMap<Category, CategoryModel>();
            CreateMap<CategoryModel, Category>();

            CreateMap<FilmActor, FilmActorModel>();
            CreateMap<FilmActorModel, FilmActor>();

            CreateMap<FilmCategory, FilmCategoryModel>();
            CreateMap<FilmCategoryModel, FilmCategory>();

        }
    }
}
