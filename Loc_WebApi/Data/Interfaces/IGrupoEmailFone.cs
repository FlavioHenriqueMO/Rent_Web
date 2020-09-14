using System.Linq;
using Loc_WebApi.Models;

namespace Loc_WebApi.Data.Interfaces
{
    public interface IGrupoEmailFone: IRepository<grupoEmailFone>
    {
         IQueryable<grupoEmailFone> GetById(int grpFoneEmailId);
    }
}