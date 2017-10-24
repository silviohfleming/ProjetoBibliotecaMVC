using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoBibliotecaMVC.Models
{
    public class Emprestimo
    {
        [Key]
        public int EmprestimoID { get; set; }

        public int UsuarioID { get; set; }
        public virtual Usuario Usuario { get; set; }

        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        [Display(Name = "Emprestado em")]
        public string DataInicio { get; set; }

        [Display(Name = "Devolver ate")]
        public string DataFim { get; set; }

        [Display(Name = "Devolvido em")]
        public string DataDevolucao { get; set; }

        public ICollection<LivroEmprestimo> LivroEmprestimo { get; set; }
    }
}
