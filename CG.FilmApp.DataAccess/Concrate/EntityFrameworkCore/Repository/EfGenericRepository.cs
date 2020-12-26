using CG.MovieApp.DataAccess.Concrate.EntityFrameworkCore.Context;
using CG.MovieApp.DataAccess.Interfaces.Dal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG.MovieApp.DataAccess.Concrate.EntityFrameworkCore.Repository
{
    public class EfGenericRepository<TEntity> : IGenericDal<TEntity> where TEntity : class, new()
    {
        public async Task Add(TEntity entity)
        {
            using(var context=new MovieAppContext())
            {
                context.Set<TEntity>().Add(entity);
                await context.SaveChangesAsync();
            }
        }

        public async Task Delete(TEntity entity)
        {
            using (var context = new MovieAppContext())
            {
                context.Set<TEntity>().Remove(entity);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<TEntity>> GetAll()
        {
            using (var context = new MovieAppContext())
            {
               return await context.Set<TEntity>().ToListAsync();
            }
        }

        public async Task<TEntity> GetById(int id)
        {
            using (var context = new MovieAppContext())
            {
                return await context.Set<TEntity>().FindAsync(id);
                
            }
        }

        public async Task Update(TEntity entity)
        {
            using (var context = new MovieAppContext())
            {
                context.Set<TEntity>().Update(entity);
                await context.SaveChangesAsync();
               
            }
        }
    }
}
