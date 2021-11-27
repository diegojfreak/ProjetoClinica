using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoClinica.Models
{
    public class MAtendimento
    {
        [DisplayName("Identificador de Atendimento")]
        public int Id { get; set; }

        [DisplayName("Horario inicial do Atendimento (hh/mm)")]
        [DataType(DataType.Time)]
        public DateTime HoraInicialAtendimento { get; set; }

        [DisplayName("Horario final da consulta (hh/mm)")]
        [DataType(DataType.Time)]
        public DateTime HoraFinalAtendimento { get; set; }

        [DataType(DataType.Password)]
        [DisplayName("Senha para Campo Observações (Opicional))")]
        [MaxLength(500)]
        public string Senha { get; set; }

        [DataType(DataType.Text)]
        [DisplayName("Observações do Atendimento")]
        [MaxLength(1000)]
        public string Observacoes { get; set; }
    }
}
