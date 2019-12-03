using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROJETO_PNET.Data {
    public class PROGNETDbContext : IdentityDbContext {
        public PROGNETDbContext(DbContextOptions<PROGNETDbContext> options)
            : base(options) {
        }

        public DbSet<PROJETO_PNET.Models.Cargos> Cargos { get; set; }
    }
}
