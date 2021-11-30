﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoClinica.Models
{
    public class MLogin
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [EmailAddress(ErrorMessage = "Informe um e-mail válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Utilize ao menos 8 caracteres")]
        [MaxLength(32, ErrorMessage = "Utilize ao máximo 32 caracteres")]
        public string Senha { get; set; }

    }
}
