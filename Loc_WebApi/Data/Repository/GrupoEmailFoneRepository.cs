using System.Linq;
using Loc_WebApi.Data.Interfaces;
using Loc_WebApi.Models;

namespace Loc_WebApi.Data.Repository
{
    public class GrupoEmailFoneRepository : Repository<grupoEmailFone>, IGrupoEmailFone
    {
        public GrupoEmailFoneRepository(DataContext context) : base(context)
        {
        }

        public IQueryable<grupoEmailFone> GetById(int grpFoneEmailId)
        {
            try
            {
                return this._context.grupoEmailFone
                .Where( dados => dados.grupoEmailId == grpFoneEmailId);
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}