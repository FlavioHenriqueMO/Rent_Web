using System.Linq;
using Loc_WebApi.Data.Interfaces;
using Loc_WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Loc_WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GrupoCadastroController : ControllerBase
    {
        private readonly IGrupoCadastro _repo;

        public GrupoCadastroController(IGrupoCadastro repo)
        {
            this._repo = repo;
        }

        [HttpGet]
        public IQueryable<grupoCadastro> Get()
        {
            try
            {
                var result = this._repo.GetAll();
                return result;
                
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        [HttpGet("{grupoCadastroId}")]
        public IQueryable<grupoCadastro> Get(int grupoCadastroId)
        {
            try
            {
                return this._repo.GetById(grupoCadastroId);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}