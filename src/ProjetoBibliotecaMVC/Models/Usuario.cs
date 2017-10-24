using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoBibliotecaMVC.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioID { get; set; }

        [Required]
        [Display(Name = "Nome Completo")]
        [MinLength(3, ErrorMessage = "O tamanho mínimo do campo {0} são {1} caracteres.")]
        [StringLength(100, ErrorMessage = "O tamanho máximo do campo {0} são {1} caracteres.")]
        public string Nome { get; set; }

        public string Telefone { get; set; }

        [Required]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required]
        [MinLength(6, ErrorMessage = "O tamanho mínimo do campo {0} são {1} caracteres.")]
        [StringLength(12, ErrorMessage = "O tamanho máximo do campo {0} são {1} caracteres.")]
        public string Senha { get; set; }

        public virtual ICollection<Emprestimo> Emprestimo { get; set; }
    }
}
