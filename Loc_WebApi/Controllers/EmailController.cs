using System.Linq;
using Loc_WebApi.Data.Interfaces;
using Loc_WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Loc_WebApi.Controllers
{
     [ApiController]
    [Route("api/[controller]")]
    public class EmailController : ControllerBase
    {
        private readonly IEmail _repo;

        public EmailController(IEmail repo)
        {
            this._repo = repo;
        }

        [HttpGet]
        public IQueryable<Emails> Get()
        {
            try
            {
                return this._repo.GetAll();
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        [HttpGet("{contatoId}")]
        public IQueryable<Emails> GetEmails(int contatoId)
        {
            try
            {
                return this._repo.GetByContatoId(contatoId);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}