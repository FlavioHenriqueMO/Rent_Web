using System.ComponentModel.DataAnnotations;

namespace Loc_WebApi.Models
{
    public class grupoEmailFone
    {
        [Key]
        public int grupoEmailId { get; set; }
        public int LocId { get; set; }
        [Required]
        [StringLength(100)]
        public string Descricao { get; set; }
        public bool? Ativo { get; set; }
        
    }
}