using Loc_WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace Loc_WebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<grupoCadastro> grupoCadastro { get; set; }
        public DbSet<grupoEmailFone> grupoEmailFones { get; set; }
        public DbSet<grupoEndereco> grupoEnderecos { get; set; }
        public DbSet<Contatos> contatos { get; set; }
        public DbSet<Emails> emails { get; set; }
        public DbSet<Endereco> enderecos { get; set; }
        public DbSet<Locadora> locadoras { get; set; }
    }
}