using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;
using Loc_WebApi.Data.Interfaces;
using Loc_WebApi.Models;

namespace Loc_WebApi.Data.Repository
{
    public class LocadoraRepository : Repository<Locadora>, ILocadora
    {

        public LocadoraRepository(DataContext context) : base(context)
        {
        }

        public IQueryable<Locadora> GetById(int id)
        {
            try
            {
                var result = this._context.locadora
                    .Where(dados => dados.LocId == id);
                return result;
            }
            catch (System.Exception)
            {

                throw;
            }
        }


    }
}