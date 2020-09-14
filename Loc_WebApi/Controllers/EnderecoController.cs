using System.Linq;
using Loc_WebApi.Data.Interfaces;
using Loc_WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Loc_WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EnderecoController : ControllerBase
    {
        private readonly IEndereco _repo;

        public EnderecoController(IEndereco repo)
        {
            this._repo = repo;
        }

        [HttpGet]
        public IQueryable<Endereco> Get()
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

        [HttpGet("{Id}")]
        public IQueryable<Endereco> GetEnderecos(int Id)
        {
            try
            {
                return this._repo.GetById(Id);
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }


        [HttpGet("contato/{contatoId}")]
        public IQueryable<Endereco> GetByContatoId(int contatoId)
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

        [HttpGet("adress/{partialAdress}")]
        public IQueryable<Endereco> GetByAdress(string partialAdress)
        {
            try
            {
                return this._repo.GetByEndereco(partialAdress);
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }


    }
}