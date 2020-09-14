using System.Linq;
using Loc_WebApi.Data.Interfaces;
using Loc_WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Loc_WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GrupoEmailFoneController : ControllerBase
    {
        private readonly IGrupoEmailFone _repo;

        public GrupoEmailFoneController(IGrupoEmailFone repo)
        {
            this._repo = repo;
        }

        [HttpGet]
        public IQueryable<grupoEmailFone> GetGrupoEmailFones()
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


        [HttpGet("{grpEmailFoneId}")]
        public IQueryable<grupoEmailFone> Get(int grpEmailFoneId)
        {
            try
            {
                return this._repo.GetById(grpEmailFoneId);
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }


    }
}