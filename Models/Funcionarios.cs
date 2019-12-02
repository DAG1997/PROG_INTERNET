using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PROJETO_PNET.Models {
    public class Funcionarios {

        [Required(ErrorMessage = "Please enter your ID")]
        public int FuncionariosId { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        public string Nome { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}
