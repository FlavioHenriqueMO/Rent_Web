using System.ComponentModel.DataAnnotations;

namespace Loc_WebApi.Models
{
    public class Contatos
    {
        public Contatos() { }

        public Contatos(int contatoId, int grupoCadastroId, int identificacaoId)
        {
            this.contatoId = contatoId;
            this.grupoCadastroId = grupoCadastroId;
            this.identificacaoId = identificacaoId;

        }
        [Key]
        public int contatoId { get; set; }

        public int grupoCadastroId { get; set; }

        public int identificacaoId { get; set; }

        public virtual grupoCadastro grupoCadastro { get; set; }

    }
}