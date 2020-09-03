using System;
using System.Threading.Tasks;
using Loc_WebApi.Data;
using Microsoft.AspNetCore.Mvc;

namespace Loc_WebApi.Controllers
{
     [ApiController]
    [Route("api/[controller]")]
    public class grupoCadastroController: ControllerBase
    {
        private readonly IRepository _repo;

        public grupoCadastroController(IRepository repo)
        {
            this._repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {

            try
            {
                var result = await this._repo.GetAllGrpCadastroAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro :(( {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetGrpContratoById(int id)
        {
            var result = await this._repo.GetGrpCadastroAsyncById(id);
            return Ok(result);
        }
 

    }
}