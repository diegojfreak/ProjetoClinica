using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoClinica.Models
{
    public class MSecretaria
    {
        [DisplayName("Identificador da Secretaria")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        [DisplayName("Nome do Usuário")]
        [MaxLength(100)]
        public string Nome { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        [DisplayName("E-mail do Usuário")]
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
