using Cadastro_e_Acesso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro_e_Acesso.ViewModel
{
    public class CadastroVM
    {
      
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public List<Estado> Estados { get; set; }

    }
}
