using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrudAluno.Models
{
    public class AlunoModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="*")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "*")]
        public String Endereco { get; set; }

        [Required(ErrorMessage = "*")]
        public String Filiacao { get; set; }

        [Required(ErrorMessage = "*")]
        public String Curso { get; set; }

        [Required(ErrorMessage = "*")]
        public String Telefone { get; set; }

        [EmailAddress(ErrorMessage = "Informe um email válido!")]
        public String Email { get; set; }




    }
}