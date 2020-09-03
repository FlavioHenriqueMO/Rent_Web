using System.ComponentModel.DataAnnotations;

namespace Loc_WebApi.Models
{
    public class Emails
    {

        public Emails()
        {

        }
        public Emails(int emailId, int locId, int contatoId, int grupoEmailId, string descricao)
        {
            this.emailId = emailId;
            this.LocId = locId;
            this.contatoId = contatoId;
            this.grupoEmailId = grupoEmailId;
            this.Descricao = descricao;

        }

        [Key]
        public int emailId { get; set; }

        public int LocId { get; set; }

        public int contatoId { get; set; }

        public int grupoEmailId { get; set; }

        [Required]
        [StringLength(100)]
        public string Descricao { get; set; }

        public bool? Ativo { get; set; }

    }
}