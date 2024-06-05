using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LookingThings.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Column("UsuarioId")]
        [Display(Name = "Código do usuário")]
        public int UsuarioId { get; set; }

        [Column("UsuarioNome")]
        [Display(Name = "Nome do usuário")]
        public string? UsuarioNome { get; set; }

        [Column("UsuarioEmail")]
        [Display(Name = "Email do usuário")]
        public string? UsuarioEmail { get; set; }

        [Column("UsuarioTelefone")]
        [Display(Name = "Telefone do usuário")]
        public string? UsuarioTelefone { get; set; }

        [Column("UsuarioSenha")]
        [Display(Name = "Senha do usuário")]
        public string? UsuarioSenha { get; set; }
    }
}
