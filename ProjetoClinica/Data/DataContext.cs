using Microsoft.EntityFrameworkCore;
using ProjetoClinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoClinica.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<MMedico> TBMedico { get; set; }

        public DbSet<MSecretaria> TBSecretaria { get; set; }

        public DbSet<MLogin> TBLogin { get; set; }

        public DbSet<MPaciente> TBPaciente { get; set; }
    }

}
