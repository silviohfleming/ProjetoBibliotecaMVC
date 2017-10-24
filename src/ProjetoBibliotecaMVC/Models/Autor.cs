using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoBibliotecaMVC.Models
{
    public class Autor
    {
        [Key]
        public int AutorID { get; set; }

        [Required]
        [Display(Name = "Nome Completo")]
        [StringLength(100, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres")]
        public string Nome { get; set; }

        public ICollection<LivroAutor> LivroAutor { get; set; }
    }
}
