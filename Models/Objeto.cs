using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LookingThings.Models
{
    [Table("Objeto")]
    public class Objeto
    {
        [Column("ObjetoId")]
        [Display(Name = "Código do objeto")]
        public int ObjetoId { get; set; }

        [Column("ObjetoNome")]
        [Display(Name = "Nome do objeto")]
        public string ObjetoNome { get; set; } = string.Empty;

        [Column("ObjetoCor")]
        [Display(Name = "Cor do objeto")]
        public string ObjetoCor { get; set; } = string.Empty;

        [Column("ObjetoObservacao")]
        [Display(Name = "Observação do objeto")]
        public string ObjetoObservacao { get; set; } = string.Empty;

        [Column("ObjetoLocalDesaparecimento")]
        [Display(Name = "Local de desaparecimento do objeto")]
        public string ObjetoLocalDesaparecimento { get; set; } = string.Empty;

        [Column("ObjetoFoto")]
        [Display(Name = "Foto do objeto")]
        public string? ObjetoFoto { get; set; }

        [Column("ObjetoDtDesaparecimento")]
        [Display(Name = "Data de desaparecimento do objeto")]
        public DateTime ObjetoDtDesaparecimento { get; set; }

        [Column("ObjetoDtEncontro")]
        [Display(Name = "Data do encontro do objeto")]
        public DateTime? ObjetoDtEncontro { get; set; }


        [Column("ObjetoStatus")]
        [Display(Name = "Status do objeto")]
        public byte ObjetoStatus { get; set; }

        [ForeignKey("UsuarioId")]
        [Display(Name = "Código do usuário")]
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
    }
}
