using Microsoft.EntityFrameworkCore;
using SMS.Infrastructure.DbContext;
using SMS.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Infrastructure.Repositories.Repos
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        private readonly ApplicationDbContext context;

        public GenericRepo(ApplicationDbContext context)
        {


            this.context = context;

        }

        public async Task<T> Create(T entity)
        {

            var e = context.Set<T>().Add(entity).Entity;

            return await Task.FromResult(e);
        }

        public Task<int> Update(T Entity)
        {
            var e = context.Set<T>().Update(Entity);

            return Task.FromResult(1);
        }

        public async Task<T> Delete(Expression<Func<T, bool>> predicate)
        {

            var e = await GetEntity(predicate);
            context.Set<T>().Remove(e);
            return await Task.FromResult(e);
        }

        public async Task<T> GetEntity(Expression<Func<T, bool>> predicate)
        {
            return await context.Set<T>().SingleOrDefaultAsync(predicate);
        }


        public async Task<List<T>> GetEntities(Expression<Func<T, bool>> predicate)
        {
            return await this.context.Set<T>().Where(predicate).ToListAsync();
        }
        public async Task<List<T>> GetEntities()
        {
            return await this.context.Set<T>().ToListAsync();
        }

        public async Task<List<T>> GetEntitiesById(Expression<Func<T, bool>> predicate)
        {

            return await context.Set<T>().Where(predicate).ToListAsync();

        }


    }
}
