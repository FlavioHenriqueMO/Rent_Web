using System;
using System.Linq;
using Loc_WebApi.Data.Interfaces;
using Loc_WebApi.Models;

namespace Loc_WebApi.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEndereco
    {
        public EnderecoRepository(DataContext context) : base(context)
        {
        }

        public IQueryable<Endereco> GetByContatoId(int contatoId)
        {
            try
            {
                return this._context.enderecos
                .Where(dados => dados.contatoId == contatoId);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public IQueryable<Endereco> GetByEndereco(string adress)
        {
            try
            {
                return this._context.enderecos
                .Where(dados => dados.Logradouro.Contains(adress));
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public IQueryable<Endereco> GetById(int adressId)
        {
             try
            {
                return this._context.enderecos
                .Where(dados => dados.enderecoId == adressId );
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
       }
    }
}