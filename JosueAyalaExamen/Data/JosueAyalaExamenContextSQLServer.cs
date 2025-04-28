using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JosueAyalaExamen.Models;

namespace JosueAyalaExamen.Data
{
    public class JosueAyalaExamenContextSQLServer : DbContext
    {
        public JosueAyalaExamenContextSQLServer (DbContextOptions<JosueAyalaExamenContextSQLServer> options)
            : base(options)
        {
        }

        public DbSet<JosueAyalaExamen.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<JosueAyalaExamen.Models.Reserva> Reserva { get; set; } = default!;
        public DbSet<JosueAyalaExamen.Models.Recompensa> Recompensa { get; set; } = default!;
    }
}
