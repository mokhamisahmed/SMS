using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Infrastructure.Repositories.Interfaces
{
    public interface IGenericRepo<T>
    {

        public Task<T> Create(T entity);

        public Task<int> Update(T Entity);


        public Task<T> Delete(Expression<Func<T, bool>> predicate);

        public Task<T> GetEntity(Expression<Func<T, bool>> predicate);


        public Task<List<T>> GetEntitiesById(Expression<Func<T, bool>> predicate);

        public  Task<List<T>> GetEntities();

        public Task<List<T>> GetEntities(Expression<Func<T, bool>> predicate);


    }
}
