using System.Linq;
using Loc_WebApi.Data.Interfaces;
using Loc_WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Loc_WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GrupoEnderecoController : ControllerBase
    {
        private readonly IGrupoEndereco _repo;
        public GrupoEnderecoController(IGrupoEndereco repo)        
        {
            this._repo = repo;
        }

        [HttpGet]
        public IQueryable<grupoEndereco> Get()
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

        [HttpGet("{grpEnderecoId}")]
        public IQueryable<grupoEndereco> Get(int grpEnderecoId)
        {
            try
            {
                return this._repo.GetById(grpEnderecoId);
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}