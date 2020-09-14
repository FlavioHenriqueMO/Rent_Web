using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loc_WebApi.Models;

namespace Loc_WebApi.Data.Interfaces
{
    public interface IRepository<T>
    {
        T Add(T entity);
        T Update(T entity);
        T Delete(T entity);

        IQueryable<T> GetAll();


    }
}