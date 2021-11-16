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

        internal object ToUpper()
        {
            throw new NotImplementedException();
        }
    }
}
