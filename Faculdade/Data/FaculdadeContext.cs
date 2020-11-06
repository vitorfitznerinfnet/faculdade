using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Faculdade.Models.Funcionarios;

namespace Faculdade.Data
{
    public class FaculdadeContext : DbContext
    {
        public FaculdadeContext (DbContextOptions<FaculdadeContext> options)
            : base(options)
        {
        }

        public DbSet<Faculdade.Models.Funcionarios.Funcionario> Funcionario { get; set; }
    }
}
