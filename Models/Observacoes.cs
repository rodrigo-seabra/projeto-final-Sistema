using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LookingThings.Models
{
    [Table("Observacoes")]
    public class Observacoes
    {
        [Column("ObservacoesId")]
        [Display(Name = "Código da Observação")]
        public int ObservacoesId { get; set; }

        [Column("ObservacoesDescricao")]
        [Display(Name = "Descrição da Observação")]
        public string? ObservacoesDescricao { get; set; }

        [Column("ObservacoesData")]
        [Display(Name = "Data da Observação")]
        public DateTime? ObservacoesData { get; set; }

        [ForeignKey("UsuarioId")]
        [Display(Name = "Código do usuário")]
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }

        [ForeignKey("ObjetoId")]
        [Display(Name = "Código do objeto")]
        public int ObjetoId { get; set; }
        public Objeto? Objeto { get; set; }

    }
}
