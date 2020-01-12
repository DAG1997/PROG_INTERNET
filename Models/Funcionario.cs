using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PROJETO_PNET.Models {
    public class Funcionario {

        [Required(ErrorMessage = "Please enter your ID")]
        public int FuncionarioId { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        [StringLength(50, MinimumLength = 3)]
        public string Nome { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Cargo")]
        public int CargosId { get; set; }
        public Cargos Cargos { get; set; }

        

    }
}
