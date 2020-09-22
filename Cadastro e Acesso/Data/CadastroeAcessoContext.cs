using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cadastro_e_Acesso.Models;
using Microsoft.EntityFrameworkCore;

namespace Cadastro_e_Acesso.Data
{
    public class CadastroeAcessoContext: DbContext
    {
        public CadastroeAcessoContext(DbContextOptions<CadastroeAcessoContext> options)
            : base(options) 
        {
        }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Estado> Estado { get; set; }
    }
}
