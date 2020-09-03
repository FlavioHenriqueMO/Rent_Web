using System.Linq;
using System.Threading.Tasks;
using Loc_WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace Loc_WebApi.Data
{
    public class Repository : IRepository
    {
        private readonly DataContext _context;
        public Repository(DataContext context)
        {
            this._context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            this._context.Add(entity);
        }
        public void Update<T>(T entity) where T : class
        {
            this._context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            this._context.Remove(entity);
        }

        public async Task<bool> SaveChangesAsyng()
        {
            return (await this._context.SaveChangesAsync()) > 0;
        }

        // Email
        public async Task<Emails[]> GetAllEmailAsync(bool includeContato)
        {
            try
            {

                IQueryable<Emails> query = this._context.emails;
                query = query.AsNoTracking().OrderBy(reg => reg.Descricao);
                return await query.ToArrayAsync();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public async Task<Emails[]> GetEmailAsyncByContatoId(int contatoId, bool includeContato)
        {
            try
            {

                IQueryable<Emails> query = this._context.emails
                    .Where(reg => reg.contatoId == contatoId);
                query = query.AsNoTracking().OrderBy(reg => reg.Descricao);
                return await query.ToArrayAsync();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        // Grupo Cadastro
        public async Task<grupoCadastro[]> GetAllGrpCadastroAsync()
        {
            try
            {
                IQueryable<grupoCadastro> query = this._context.grupoCadastro;
                return await query.ToArrayAsync();
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public async Task<grupoCadastro[]> GetGrpCadastroAsyncById(int grpId)
        {
            try
            {
                IQueryable<grupoCadastro> query = this._context.grupoCadastro
                .Where( reg => reg.grupoCadastroId == grpId );
                return await query.ToArrayAsync();
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}