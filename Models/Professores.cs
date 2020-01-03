using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PROJETO_PNET.Models
{
    public class Professores
    {
        [Required(ErrorMessage = "Please enter your ID")]
        public int ProfessoresId { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        [StringLength(50, MinimumLength = 3)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Please enter your number")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "Please enter your classes")]
        public string Aulas { get; set; }

        [Required(ErrorMessage = "Please enter your Email")]
        public string Email { get; set; }
        
  
    }
}
