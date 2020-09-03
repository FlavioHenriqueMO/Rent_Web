using System.ComponentModel.DataAnnotations;

namespace Loc_WebApi.Models
{
    public class Locadora
    {
        public Locadora() {}

        [Key]
        public int LocId { get; set; }

        [Required]
        [StringLength(200)]
        public string NomeFantasia { get; set; }

        [Required]
        [StringLength(200)]
        public string RazaoSocial { get; set; }

        [Required]
        [StringLength(14)]
        public string CNPJ { get; set; }

        public int LojaNro { get; set; }

        public bool? Ativo { get; set; }
        
    }
}