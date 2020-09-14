using System.Linq;
using Loc_WebApi.Models;

namespace Loc_WebApi.Data.Interfaces
{
    public interface IGrupoEndereco: IRepository<grupoEndereco>
    {
        IQueryable<grupoEndereco> GetById( int grpEnderecoId);
         
    }
}