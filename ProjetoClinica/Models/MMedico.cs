using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoClinica.Models
{
    public class MMedico
    {
        [DisplayName("Identificador de Médico")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        [DisplayName("Nome do Médico")]
        [MaxLength(100)]
        public string Nome { get; set; }

        [MaxLength(50)]
        [Required(ErrorMessage ="Campo Obrigatório!")]
        [DisplayName("Registro Conselho Regional de Medicina (CRM)")]
        public string CRM { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage ="Campo Obrigatório!")]
        [DisplayName("E-mail do Médico")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Data obrigatória")]
        [DisplayName("Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        [MaxLength(50)]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        [DisplayName("Registro Cadastro Pessoa Física (CPF)")]
        public string CPF { get; set; }
    }
}
