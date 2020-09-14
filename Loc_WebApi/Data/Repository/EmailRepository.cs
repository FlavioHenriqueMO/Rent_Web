using System.Linq;
using Loc_WebApi.Data.Interfaces;
using Loc_WebApi.Models;

namespace Loc_WebApi.Data.Repository
{
    public class EmailRepository : Repository<Emails>, IEmail
    {
        public EmailRepository(DataContext context) : base(context)
        {
        }

        public IQueryable<Emails> GetByContatoId(int id)
        {
            try
            {
                return this._context.emails
                    .Where(dados => dados.contatoId == id);

            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}