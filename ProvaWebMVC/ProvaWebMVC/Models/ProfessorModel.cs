using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProvaWebMVC.Models
{
    public class ProfessorModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "*")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "*")]
        public String Endereço { get; set; }
        [Required(ErrorMessage = "*")]
        public String Telefone { get; set; }

        [EmailAddress(ErrorMessage = "Infome um email valido!")]
        public String Email { get; set; }
        [Required(ErrorMessage = "*")]
        public String Disciplina { get; set; }
    }
}