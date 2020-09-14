using System.Linq;
using Loc_WebApi.Models;

namespace Loc_WebApi.Data.Interfaces
{
    public interface IEndereco: IRepository<Endereco>
    {
        IQueryable<Endereco> GetById( int adressId);
        IQueryable<Endereco> GetByContatoId(int contatoId);
        IQueryable<Endereco> GetByEndereco( string adress);
         
    }
}