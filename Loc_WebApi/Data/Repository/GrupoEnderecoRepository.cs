using System.Linq;
using Loc_WebApi.Data.Interfaces;
using Loc_WebApi.Models;

namespace Loc_WebApi.Data.Repository
{
    public class GrupoEnderecoRepository : Repository<grupoEndereco>, IGrupoEndereco
    {
        public GrupoEnderecoRepository(DataContext context) : base(context)
        {
        }

        public IQueryable<grupoEndereco> GetById(int grpEnderecoId)
        {
            try
            {
                return this._context.grupoEndereco
                .Where( dados => dados.grupoEnderecoId == grpEnderecoId);
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}