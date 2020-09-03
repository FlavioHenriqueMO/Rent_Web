using System.ComponentModel.DataAnnotations;

namespace Loc_WebApi.Models
{
    public class grupoCadastro
    {
        public grupoCadastro()
        {
        }
        [Key]
        public int grupoCadastroId { get; set; }
        public int LocId { get; set; }
        [Required]
        [StringLength(100)]
        public string Descricao { get; set; }
        public bool? Ativo { get; set; }
    }
}