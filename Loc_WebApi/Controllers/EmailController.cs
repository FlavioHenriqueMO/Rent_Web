using System;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;
using Loc_WebApi.Data;
using Microsoft.AspNetCore.Mvc;

namespace Loc_WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmailController : ControllerBase
    {
        private readonly IRepository _repo;
        public EmailController(IRepository repo)
        {
            this._repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {

            try
            {
                var result = await this._repo.GetAllEmailAsync(false);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro :( {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmailByCtrId(int id)
        {
            var result = await this._repo.GetEmailAsyncByContatoId(id, false);
            return Ok(result);
        }
    }
}