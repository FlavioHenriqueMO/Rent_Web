using System.Linq;
using Loc_WebApi.Data.Interfaces;
using Loc_WebApi.Models;

namespace Loc_WebApi.Data.Repository
{
    public class GrupoCadastroRepository : Repository<grupoCadastro>, IGrupoCadastro
    {
        public GrupoCadastroRepository(DataContext context) : base(context)
        {
        }

        public IQueryable<grupoCadastro> GetById(int grupoId)
        {
            try
            {
                return this._context.grupoCadastro
                .Where( dados => dados.grupoCadastroId == grupoId);                
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}