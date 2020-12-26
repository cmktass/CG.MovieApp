using CG.MovieApp.Business.Interfaces;
using CG.MovieApp.DataAccess.Interfaces.Dal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CG.MovieApp.Business.Concrete
{
    public class GenericService<TEntity> : IGenericService<TEntity> where TEntity: class,new()
    {

        private IGenericDal<TEntity> genericDal;

        public GenericService(IGenericDal<TEntity> genericDal)
        {
            this.genericDal = genericDal;
        }

        public async Task Add(TEntity entity)
        {
            await genericDal.Add(entity);
        }

        public Task Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TEntity>> GetAll()
        {
            return  await genericDal.GetAll();
        }

        public Task<TEntity> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
