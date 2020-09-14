using System.Linq;
using System.Threading.Tasks;
using Loc_WebApi.Models;

namespace Loc_WebApi.Data.Interfaces
{
    public interface ILocadora : IRepository<Locadora>
    {
        
        IQueryable<Locadora> GetById(int id);
        
    }

    
}