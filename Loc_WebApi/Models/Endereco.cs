using System.ComponentModel.DataAnnotations;

namespace Loc_WebApi.Models
{
    public class Endereco
    {
        public Endereco() { }

        public Endereco(int enderecoId, int locId, int contatoId, int grupoCadastroId, int grupoEnderecoId, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string latitude, string longitude)
        {
            this.enderecoId = enderecoId;
            this.LocId = locId;
            this.contatoId = contatoId;
            this.grupoCadastroId = grupoCadastroId;
            this.grupoEnderecoId = grupoEnderecoId;
            this.Logradouro = logradouro;
            this.Numero = numero;
            this.Complemento = complemento;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = estado;
            this.Latitude = latitude;
            this.Longitude = longitude;

        }
        [Key]
        public int enderecoId { get; set; }
        public int LocId { get; set; }
        public int contatoId { get; set; }
        public int grupoCadastroId { get; set; }
        public int grupoEnderecoId { get; set; }
        [Required]
        [StringLength(100)]
        public string Logradouro { get; set; }
        [Required]
        [StringLength(20)]
        public string Numero { get; set; }
        [StringLength(50)]
        public string Complemento { get; set; }
        [StringLength(50)]
        public string Bairro { get; set; }
        [Required]
        [StringLength(50)]
        public string Cidade { get; set; }
        [Required]
        [StringLength(2)]
        public string Estado { get; set; }
        [StringLength(100)]
        public string Latitude { get; set; }
        [StringLength(100)]
        public string Longitude { get; set; }
        public bool? Ativo { get; set; }
        // public virtual Contatos Contatos { get; set; }
        // public virtual grupoCadastro grupoCadastro { get; set; }
        // public virtual Locadora Locadora { get; set; }

    }
}