using System.Linq;
using System.Threading.Tasks;
using Loc_WebApi.Data.Interfaces;
using Loc_WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Loc_WebApi.Data
{
    public class Repository<T> : IRepository<T> where T: class
    {
        protected DataContext _context;
        protected DbSet<T> dbSet;
        public Repository(DataContext context)
        {
            this._context = context;
            this.dbSet = this._context.Set<T>();
        }

        public Repository()
        {
        }

        public T Add(T entity)
        {
            throw new System.NotImplementedException();
        }

        public T Update(T entity)
        {
            throw new System.NotImplementedException();
        }

        public T Delete(T entity)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            return this.dbSet.AsNoTracking();
        }
    }
}