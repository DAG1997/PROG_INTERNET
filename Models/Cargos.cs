using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PROJETO_PNET.Models {
    public class Cargos {
        public int CargosId { get; set; }

        [Required]
        public string NomeCargo { get; set; }

        [Required]

        public string Funcao  { get; set; }

        
    }
}
