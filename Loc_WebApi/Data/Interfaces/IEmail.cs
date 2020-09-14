using System.Linq;
using Loc_WebApi.Models;

namespace Loc_WebApi.Data.Interfaces
{
    public interface IEmail: IRepository<Emails>
    {
         IQueryable<Emails> GetByContatoId(int id);
    }
}