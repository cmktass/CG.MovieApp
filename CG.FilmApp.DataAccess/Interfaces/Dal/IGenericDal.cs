using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CG.MovieApp.DataAccess.Interfaces.Dal
{
    public interface IGenericDal<TEntity> where TEntity:class,new()
    {
        Task<List<TEntity>> GetAll();

        Task<TEntity> GetById(int id);

        Task Add(TEntity entity);

        Task Update(TEntity entity);

        Task Delete(TEntity entity);

            
    }
}
