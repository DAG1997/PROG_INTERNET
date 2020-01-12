using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PROJETO_PNET.Models {
    public class Cargos {
        public int CargosId { get; set; }

        [Required(ErrorMessage = "Por favor introuza um cargo! ")]
        [StringLength(50, MinimumLength = 3)]
        public string NomeCargo { get; set; }

        [Required(ErrorMessage = " Por favor introduza uma função!")]
        [StringLength(50, MinimumLength = 3)]

        public string Funcao  { get; set; }

        public ICollection<Funcionario> Funcionarios;

        

        
    }
}
