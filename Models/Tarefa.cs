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

        [Required(ErrorMessage = "Por favor, introduza o nome da tarefa")]
        public string NomeTarefa { get; set; }

        [Required(ErrorMessage = "Por favor, introduza quando a tarefa foi realizada")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataTarefa { get; set; }

        [Required(ErrorMessage = "Por favor, introduza o cargo a que a tarefa se destina")]
        public int FuncionarioId { get; set; }
        public Funcionario Funcionario { get; set; }

    }
}
