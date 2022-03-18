using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevWeekPhilips;

namespace DevWeekPhilips.Data
{
    public class AppDbContext : DbContext
    {
       
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Regiao> Regiao { get; set; }

        public DbSet<FaixaEtaria> Faixa_Etaria { get; set; }

        public DbSet<IncidenciaExame> Incidencia_Exame { get; set; }
    }
}
