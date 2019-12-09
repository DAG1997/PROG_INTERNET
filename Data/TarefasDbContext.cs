using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROJETO_PNET.Data {
   
        public class TarefasDbContext : DbContext {
            public TarefasDbContext(DbContextOptions<TarefasDbContext> options)
                : base(options) {
            }

            public DbSet<PROJETO_PNET.Models.Cargos> Cargos { get; set; }


        }
    }

