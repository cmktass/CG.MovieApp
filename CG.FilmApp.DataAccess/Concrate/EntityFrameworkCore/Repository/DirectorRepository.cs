using CG.MovieApp.DataAccess.Interfaces.Dal;
using CG.MovieAppEntity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CG.MovieApp.DataAccess.Concrate.EntityFrameworkCore.Repository
{
    public class DirectorRepository:EfGenericRepository<Director>,IDirectorDal
    {

    }
}
