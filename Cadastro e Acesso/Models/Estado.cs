using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Cadastro_e_Acesso.Models
{
    public class Estado
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string NomeEstado { get; set; }
        [Required]
        public string UnidadeFederativa { get; set; }
    }
}
