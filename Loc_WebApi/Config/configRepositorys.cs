using Loc_WebApi.Data.Interfaces;
using Loc_WebApi.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Loc_WebApi.Config
{
    public static class configRepositorys
    {
        public static void Config(IServiceCollection services)
        {
            services.AddScoped<ILocadora, LocadoraRepository>();   
            services.AddScoped<IEmail, EmailRepository>(); 
            services.AddScoped<IGrupoEmailFone, GrupoEmailFoneRepository>(); 
            services.AddScoped<IGrupoEndereco, GrupoEnderecoRepository>(); 
            services.AddScoped<IEndereco, EnderecoRepository>(); 

        }
        
    }
}