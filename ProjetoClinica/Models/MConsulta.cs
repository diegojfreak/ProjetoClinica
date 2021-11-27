using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoClinica.Models
{
    public class MConsulta
    {
        [DisplayName("Identificador de Consulta")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!Apenas um paciente por consulta")]
        [DisplayName("Nome do Paciente")]
        [MaxLength(100)]
        public string Paciente { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!Apenas um médico por consulta")]
        [DisplayName("Nome do Médico")]
        [MaxLength(100)]
        public string Medico { get; set; }

        [Required(ErrorMessage = "Data obrigatória")]
        [DisplayName("Data da consulta (dd/mm/yyyy)")]
        [DataType(DataType.Date)]
        public DateTime DataConsulta { get; set; }

        [Required(ErrorMessage = "Horario obrigatória")]
        [DisplayName("Horario da consulta (hh/mm)")]
        [DataType(DataType.Time)]

        public DateTime HoraConsulta { get; set; }

        [Required(ErrorMessage = "Selecione o modo de pagamento")]
        [DisplayName("Forma de Pagamento")]
        [DataType(DataType.Text)]
        public string FormaPagamento { get; set; }

        [DataType(DataType.Text)]
        [DisplayName("Observações do Consulta")]
        [MaxLength(1000)]
        public string Observacoes { get; set; }

        [DataType(DataType.Text)]
        [DisplayName("Status da Consulta")]
        [MaxLength(500)]
        public string StatusConsulta { get; set; }

        internal object ToUpper()
        {
            throw new NotImplementedException();
        }
    }
}
