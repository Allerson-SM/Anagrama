using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Anagrama.Api.Model
{
    public class Anagramas
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo de palavra é obrigatório")]
        public string Palavra { get; set; }
    }
}