using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoClinica.Models
{
    public class MAgenda
    {
        [DisplayName("Identificador de Agendamento")]
        public int Id { get; set; }

        [DisplayName("Data da consulta (dd/mm/yyyy)")]
        [DataType(DataType.Date)]
        public DateTime DataConsulta { get; set; }

        [DisplayName("Horario inicial da consulta (hh/mm)")]
        [DataType(DataType.Time)]
        public DateTime HoraInicialConsulta { get; set; }

        [DisplayName("Horario final da consulta (hh/mm)")]
        [DataType(DataType.Time)]
        public DateTime HoraFinalConsulta { get; set; }

        [Required(ErrorMessage = "Senha obrigatória")]
        [DataType(DataType.Password)]
        [DisplayName("observações:)")]
        [MaxLength(500)]
        public string Senha { get; set; }
    }
}
