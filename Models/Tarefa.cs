using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PROJETO_PNET.Models
{
    public class Tarefa
    {
        public int TarefaId { get; set; }

        public int Nivel { get; set; }

        [Required(ErrorMessage = "Por favor, introduza o nome da tarefa")]
        public string NomeTarefa { get; set; }

        public DateTime DataTarefa { get; set; }

        [Required(ErrorMessage = "Por favor, introduza o cargo a que a tarefa se destina")]
        public int CargoId { get; set; }
        public Cargos Cargos { get; set; }

    }
}
