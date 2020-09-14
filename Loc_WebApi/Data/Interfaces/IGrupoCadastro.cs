using System.Linq;
using Loc_WebApi.Models;

namespace Loc_WebApi.Data.Interfaces
{
    public interface IGrupoCadastro: IRepository<grupoCadastro>
    {
        IQueryable<grupoCadastro> GetById(int grupoId);
         
    }
}