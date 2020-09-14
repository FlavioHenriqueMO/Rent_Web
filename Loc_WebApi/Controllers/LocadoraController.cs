using System.Linq;
using System;
using System.Threading.Tasks;
using Loc_WebApi.Data;
using Loc_WebApi.Data.Interfaces;
using Loc_WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Loc_WebApi.Controllers
{
     [ApiController]
    [Route("api/[controller]")]
    public class LocadoraController: ControllerBase
    {
        private readonly ILocadora _repo;
        
        public LocadoraController(ILocadora repo)
        {
            this._repo = repo;
        }

        [HttpGet]
        public IQueryable<Locadora> Get()
        {
            var result = this._repo.GetAll();
            return result;
        }

        [HttpGet("{id}")]
        public IQueryable<Locadora> Get(int id)
        {
            var result = this._repo.GetById(id);
            return result;
        }

    }
}