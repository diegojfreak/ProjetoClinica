using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoClinica.Models
{
    public class MPaciente
    {
        [DisplayName("Identificador de Paciente")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        [DisplayName("Nome do Paciente")]
        [MaxLength(100)]
        public string Nome { get; set; }

        [MaxLength(50)]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        [DisplayName("Registro Cadastro Pessoa Física (CPF)")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Data obrigatória")]
        [DisplayName("Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        [DisplayName("Endereço do Paciente")]
        public string Endereco { get; set; }

        [MaxLength(50)]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        [DisplayName("Telefone para Contato")]
        public string Telefone { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        [DisplayName("E-mail do Paciente")]
        public string Email { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        [DisplayName("Profissão do Paciente")]
        public string Profissao { get; set; }

        [MaxLength(50)]
        [DisplayName("Sexo do Paciente")]
        public string Sexo { get; set; }
    }
}
