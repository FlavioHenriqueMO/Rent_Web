using System.Threading.Tasks;
using Loc_WebApi.Models;

namespace Loc_WebApi.Data
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsyng();

        // Email
        Task<Emails[]> GetAllEmailAsync(bool includeContato);
        Task<Emails[]> GetEmailAsyncByContatoId(int contatoId, bool includeContato);

        // Grupo Cadastro
        Task<grupoCadastro[]> GetAllGrpCadastroAsync();
        Task<grupoCadastro[]> GetGrpCadastroAsyncById(int grpId);


    }
}