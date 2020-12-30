using CG.MovieApp.DataAccess.Concrate.EntityFrameworkCore.Context;
using CG.MovieApp.DataAccess.Interfaces.Dal;
using CG.MovieAppEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CG.MovieApp.DataAccess.Concrate.EntityFrameworkCore.Repository
{
    public class ActorRepository : EfGenericRepository<Actor>, IActorDal
    {
        public Actor GetByName(string name)
        {
            using(var db=new MovieAppContext())
            {
                return db.Actors.Where(i=>i.Name.ToLower().Trim()==name.ToLower().Trim()).FirstOrDefault();
            }
        }
    }
}
