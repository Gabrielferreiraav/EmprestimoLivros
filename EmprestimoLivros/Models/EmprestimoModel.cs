using System.ComponentModel.DataAnnotations;

namespace EmprestimoLivros.Models
{
    public class EmprestimoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Quem esta recebendo ?")]
        public string Recebedor { get; set; }

        [Required(ErrorMessage = "Quem esta Emprestando ?")]
        public string Fornecedor { get; set; }

        [Required(ErrorMessage = "Qual o livro emprestado ?")]
        public string LivroEmprestado { get; set; }

        public DateTime UltimaAlteracao { get; set; } 
    }
}
